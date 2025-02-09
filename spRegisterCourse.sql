
CREATE PROCEDURE spRegisterCourse

-- parameters
@StudentID INT,
@SectionID INT,
@Year INT,
@Term VARCHAR(10)


AS
BEGIN
    BEGIN TRANSACTION;

    /* Checking if the prereqs are met */
    IF EXISTS (
        SELECT 1
        FROM Prereq p
        JOIN TakenCourses t ON p.PrereqID = t.CourseID
        WHERE p.CourseID = (SELECT CourseID FROM Section WHERE SectionID = @SectionID)
        AND t.StudentID = @StudentID
    )
    BEGIN
        -- check for time conflict
        IF NOT EXISTS (
            SELECT 1
            FROM ShoppingCart sc
            JOIN Section s1 ON sc.SectionID = s1.SectionID
            JOIN Section s2 ON s1.SectionID = @SectionID
            WHERE sc.StudentID = @StudentID
              AND s1.Term = @Term
              AND s1.Year = @Year
              AND (
                  (s1.Time BETWEEN s2.Time AND DATEADD(MINUTE, s2.Duration, s2.Time))
                  OR (s2.Time BETWEEN s1.Time AND DATEADD(MINUTE, s1.Duration, s1.Time))
              )
        )
        BEGIN
            -- if section full
            DECLARE @CurrentEnrollment INT;
            DECLARE @Capacity INT;

            SELECT @CurrentEnrollment = EnrolledCount, @Capacity = Capacity
            FROM Section
            WHERE SectionID = @SectionID;

            IF @CurrentEnrollment < @Capacity
            BEGIN

                -- inserting into shopping cart
                INSERT INTO ShoppingCart (StudentID, SectionID, Year, Term, Time)
                VALUES (@StudentID, @SectionID, @Year, @Term, GETDATE());

                -- updating the enrolled count
                UPDATE Section
                SET EnrolledCount = EnrolledCount + 1
                WHERE SectionID = @SectionID;

                COMMIT TRANSACTION;
                RETURN;
            END
            ELSE
            BEGIN
                ROLLBACK TRANSACTION;
                THROW 100000, 'This section is full. Please select another section.', 1;
            END
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
            THROW 100001, 'Time conflict. Please select another time.', 1;
        END
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 100002, 'The pre-requisites are not met for this course.', 1;
    END

END;