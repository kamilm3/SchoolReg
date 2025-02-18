DROP PROCEDURE IF EXISTS CheckTimeConflict;
GO

create procedure CheckTimeConflict
    @StudentID int,
    @CourseID int
as
begin
  
    -- Check if the course being added conflicts with any existing courses in the student's cart
    -- OR with courses the student is already enrolled in
    select c2.CourseID as ConflictingCourseID, c2.CourseName as ConflictingCourseName, c2.DayOfWeek, c2.StartTime, c2.EndTime
    from dbo.Courses c2, dbo.Courses c1
    where c1.DayOfWeek = c2.DayOfWeek  -- Match courses on the same day
    and c2.CourseID = @CourseID  -- Check against the course being added
    and ((c1.StartTime >= c2.StartTime and c1.StartTime < c2.EndTime)  -- Overlaps at the start
        or (c1.EndTime > c2.StartTime and c1.EndTime <= c2.EndTime)  -- Overlaps at the end
        or (c1.StartTime <= c2.StartTime and c1.EndTime >= c2.EndTime))  -- One course fully overlaps another
    and (exists (
            select* from dbo.ShoppingCart sc 
            where sc.StudentID = @StudentID 
            and sc.CourseID = c1.CourseID)
        or exists (
            select * from dbo.Enroll e
            where e.StudentID = @StudentID 
            and e.CourseID = c1.CourseID));
end;