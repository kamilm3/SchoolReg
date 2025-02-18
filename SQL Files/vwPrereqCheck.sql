create view vwPrereqCheck
with SCHEMABINDING
as
select p.CourseID,
    tc.StudentID,
    count_big(*) as PrereqsCompleted
from dbo.Prereq p
join dbo.TakenCourses tc on p.PrereqID = tc.CourseID
join dbo.Student s on tc.StudentID = s.StudentID
    where s.Status = 'Active'
GROUP BY p.CourseID, tc.StudentID;
go

CREATE UNIQUE CLUSTERED INDEX IDX_vwPrereqEligibility_cidSID
ON vwPrereqCheck (CourseID, StudentID);
GO
