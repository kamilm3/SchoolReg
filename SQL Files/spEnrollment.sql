CREATE PROCEDURE spEnrollment
-- parameters
@StudentID INT,
@CourseID VARCHAR(10),
@SectionID INT,
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
        @CourseID = CourseID
    FROM vwEnrollCapacity
    WHERE CourseID = @CourseID AND SectionID = @SectionID;

    -- if section full
    IF @CurrentEnrollment >= @Capacity
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50001, 'This section is full. Please select another section.', 1;
    END

    -- capacity not full = finalizing enrolment
    UPDATE Section
    SET EnrolledCount = EnrolledCount + 1
    WHERE SectionID = @SectionID;

    -- deleting course from shopping cart since student just enrolled in it
    DELETE FROM ShoppingCart
    WHERE StudentID = @StudentID AND CourseID = @CourseID AND SectionID = @SectionID;
    COMMIT TRANSACTION;

    RETURN;
END;
GO
