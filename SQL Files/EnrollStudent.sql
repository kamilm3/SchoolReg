DROP PROCEDURE IF EXISTS EnrollStudent;
GO
create procedure EnrollStudent
    @StudentID int,
    @CourseID int
as
begin
    begin transaction;
    begin try
        -- Check if the course is full
        if (select COUNT(*) from Enroll where CourseID = @CourseID) 
           >= (select Capacity from Classroom where ClassroomID = 
              (select ClassroomID from Courses where CourseID = @CourseID))
        begin
		-- Return if course is full
            return;
        end

        -- Enroll the student
        insert into Enroll (StudentID, CourseID)
        values (@StudentID, @CourseID);

        -- Increment the enrollment count in the Courses table
        update Courses
        set EnrolledStudents = EnrolledStudents + 1
        where CourseID = @CourseID;

        -- Commit the transaction if everything is successful
        commit transaction;
    end try
    begin catch
        -- If an error occurs, rollback
        rollback transaction;
    end catch
end;