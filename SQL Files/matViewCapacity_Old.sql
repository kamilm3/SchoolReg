DROP VIEW IF EXISTS vwEnrollCapacity;
GO

CREATE VIEW vwEnrollCapacity
WITH SCHEMABINDING
AS
SELECT 
    Courses.CourseID,
    Courses.Year,
    Courses.Term,
    Classroom.Capacity,
    COUNT_BIG(*) AS TotalRecords,
    COUNT_BIG(Enroll.StudentID) AS EnrolledCount,
    COUNT_BIG(TakenCourses.CourseID) AS PrereqCoursesCompleted
FROM dbo.Courses
JOIN dbo.Classroom ON Courses.ClassroomID = Classroom.ClassroomID  -- Capacity from Classroom table
JOIN dbo.Enroll ON Courses.CourseID = Enroll.CourseID  -- Counting enrolled students
JOIN dbo.TakenCourses ON Enroll.StudentID = TakenCourses.StudentID  -- Counting prerequisites completed
GROUP BY Courses.CourseID, Courses.Year, Courses.Term, Classroom.Capacity;
GO

-- unique clustered index
CREATE UNIQUE CLUSTERED INDEX IDX_vwEnrollCapacity_CourseID
ON vwEnrollCapacity (CourseID, Year, Term);
GO