CREATE PROCEDURE spEnrollment
-- parameters
@StudentID INT,
@CourseID VARCHAR(10),
@Year INT,
@Term VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    -- variables to store current enrollment count and section capacity
    DECLARE @CurrentEnrollment INT;
    DECLARE @Capacity INT;

    -- getting enrollment count and capacity from materialized view
    SELECT 
        @CurrentEnrollment = EnrolledCount,
        @Capacity = Capacity,
    FROM vwEnrollCapacity -- THE MAT VIEWWW
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
