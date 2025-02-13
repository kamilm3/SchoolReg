CREATE VIEW vwEnrollCapacity
WITH SCHEMABINDING
AS
SELECT 
    c.CourseID,
    c.Year,
    c.Term,
    cr.Capacity,
    COUNT_BIG(e.StudentID) AS EnrolledCount,
    COUNT_BIG(tc.CourseID) AS PrereqCoursesCompleted
FROM Courses c
JOIN Classroom cr ON c.ClassroomID = cr.ClassroomID  -- capacity from Classroom table
LEFT JOIN Enroll e ON c.CourseID = e.CourseID  -- countig enrolled students
LEFT JOIN TakenCourses tc ON e.StudentID = tc.StudentID  -- counting prerequisites completed
GROUP BY c.CourseID, c.Year, c.Term, cr.Capacity;
GO

-- unique clustered index
CREATE UNIQUE CLUSTERED INDEX IDX_vwEnrollCapacity_CourseID
ON vwEnrollCapacity (CourseID, Year, Term);
GO
