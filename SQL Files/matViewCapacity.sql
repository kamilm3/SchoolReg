CREATE VIEW vwEnrollCapacity
WITH SCHEMABINDING
AS
SELECT 
    c.CourseID,
    c.Year,
    c.Term,
    cr.Capacity,
	COUNT_BIG(*) AS TotalRecords,
    COUNT_BIG(e.StudentID) AS EnrolledCount,
    COUNT_BIG(tc.CourseID) AS PrereqCoursesCompleted
FROM dbo.Courses c
JOIN dbo.Classroom cr ON c.ClassroomID = cr.ClassroomID  -- capacity from Classroom table
JOIN dbo.Enroll e ON c.CourseID = e.CourseID  -- countig enrolled students
JOIN dbo.TakenCourses tc ON e.StudentID = tc.StudentID  -- counting prerequisites completed
GROUP BY c.CourseID, c.Year, c.Term, cr.Capacity;
GO

-- unique clustered index
CREATE UNIQUE CLUSTERED INDEX IDX_vwEnrollCapacity_CourseID
ON vwEnrollCapacity (CourseID, Year, Term);
GO

DROP VIEW IF EXISTS vwEnrollCapacity;
GO
