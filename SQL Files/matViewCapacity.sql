DROP VIEW IF EXISTS vwEnrollCapacity;
GO

CREATE VIEW vwEnrollCapacity
WITH SCHEMABINDING
AS
SELECT 
    c.CourseID,
    c.Year,
    c.Term,
    cl.Capacity,
    COUNT_BIG(*) AS EnrolledCount
FROM dbo.Courses c
JOIN dbo.Classroom cl ON c.ClassroomID = cl.ClassroomID
JOIN dbo.Enroll e ON c.CourseID = e.CourseID
GROUP BY c.CourseID, c.Year, c.Term, cl.Capacity;
GO

-- Create the unique clustered index
CREATE UNIQUE CLUSTERED INDEX IDX_vwEnrollCapacity_CourseID
ON vwEnrollCapacity (CourseID, Year, Term);
GO