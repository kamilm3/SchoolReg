IF OBJECT_ID('spEnrollment', 'P') IS NOT NULL
    DROP PROCEDURE spEnrollment;
GO

CREATE PROCEDURE spEnrollment
-- parameters
@StudentID INT,
@CourseID INT,
@Year INT,
@Term VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    -- checking if already enrolled
    IF EXISTS (
        SELECT 1 FROM Enroll
        WHERE StudentID = @StudentID AND CourseID = @CourseID
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 100003, 'Already enrolled in this course.', 1;
    END

    -- checking prerequisites
    IF EXISTS (
        SELECT 1
        FROM Prereq p
        WHERE p.CourseID = @CourseID
          AND NOT EXISTS (
              SELECT 1
              FROM TakenCourses t
              WHERE t.StudentID = @StudentID
                AND t.CourseID = p.PrereqID
          )
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 100001, 'All prerequisites not fulfilled.', 1;
    END

    -- checking scheduling conflicts
    IF EXISTS (
        SELECT 1
        FROM CourseTimes newCT
        WHERE newCT.CourseID = @CourseID
        -- ^^ select the times of the current course

          AND EXISTS (
              -- vv get all the course times, but only consider some to actually check for conflicts
              SELECT 1
              FROM CourseTimes oldCT
              WHERE oldCT.CourseID IN (

                    -- 1) only consider the courses that the student is enrolled in
                    SELECT c.CourseID
                    FROM Enroll e
                    -- join to get the Year & Term of the courses student is enrolled in
                    JOIN Courses c ON e.CourseID = c.CourseID
                    WHERE e.StudentID = @StudentID
                    -- 2) also only consider them if they're in the same year and term
                      AND c.Year = @Year
                      AND c.Term = @Term
              
              )

              -- 3) also only consider them if they're on the same day
              AND oldCT.DayID = newCT.DayID
              AND newCT.StartTimeMins < (oldCT.StartTimeMins + oldCT.DurationMins)
              AND (newCT.StartTimeMins + newCT.DurationMins) > oldCT.StartTimeMins
              -- ^^ end of the search
          )
    )
    BEGIN
         ROLLBACK TRANSACTION;
         THROW 100002, 'Scheduling conflict detected.', 1;
    END

    -- variables to store current enrollment count and section capacity
    DECLARE @CurrentEnrollment INT;
    DECLARE @Capacity INT;

    -- getting enrollment count and capacity from materialized view
    SELECT 
        @CurrentEnrollment = EnrolledCount,
        @Capacity = Capacity
    FROM vwEnrollCapacity -- THE MAT VIEW
    WHERE CourseID = @CourseID AND Year = @Year AND Term = @Term;

    -- if section full
    IF @CurrentEnrollment >= @Capacity
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 100000, 'Course is full.', 1;
    END

    -- capacity not full = finalizing enrolment
    INSERT INTO Enroll (StudentID, CourseID)
    VALUES (@StudentID, @CourseID);

    -- deleting course from shopping cart since student just enrolled in it
    DELETE FROM ShoppingCart
    WHERE StudentID = @StudentID AND CourseID = @CourseID;
    COMMIT TRANSACTION;

    RETURN;
END;
GO