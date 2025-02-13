CREATE PROCEDURE spEnrollment
-- parameters
@StudentID INT,
@CourseID VARCHAR(10),
@Year INT,
@Term VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

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
        THROW 100001, 'Student has not fulfilled all prerequisites.', 1;
    END

    -- checking scheduling conflicts
    DECLARE @NewCourseStart INT;
    DECLARE @NewCourseDuration INT;
    DECLARE @NewCourseDay INT;

    SELECT @NewCourseStart = StartTimeMins,
           @NewCourseDuration = DurationMins,
           @NewCourseDay = DayOfWeek
    FROM Courses
    WHERE CourseID = @CourseID AND Year = @Year AND Term = @Term;

    IF EXISTS (
         SELECT 1
         FROM Enroll e
         JOIN Courses c ON e.CourseID = c.CourseID
         WHERE e.StudentID = @StudentID
           AND c.Year = @Year AND c.Term = @Term
           AND c.DayOfWeek = @NewCourseDay
           AND @NewCourseStart < (c.StartTimeMins + c.DurationMins)
           AND (@NewCourseStart + @NewCourseDuration) > c.StartTimeMins
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