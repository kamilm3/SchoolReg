CREATE VIEW vwEnrollCapacity
WITH SCHEMABINDING
AS
SELECT 
    s.SectionID,
    s.CourseID,
    s.Term,
    s.Year,
    s.Capacity,
    COUNT_BIG(sc.StudentID) AS EnrolledCount,
    COUNT_BIG(tc.CourseID) AS PrereqCoursesCompleted
FROM Section s
LEFT JOIN ShoppingCart sc ON s.SectionID = sc.SectionID
LEFT JOIN TakenCourses tc ON sc.StudentID = tc.StudentID
GROUP BY s.SectionID, s.CourseID, s.Term, s.Year, s.Capacity;
GO

-- unique clustered index
CREATE UNIQUE CLUSTERED INDEX IDX_vwEnrollCapacity_SectionID
ON vwEnrollCapacity (SectionID);
GO