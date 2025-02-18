DROP VIEW IF EXISTS dbo.vwActiveStudentPrereqs;
GO

create view vwActiveStudentPrereqs
with schemabinding
as
select 
    p.CourseID,
    s.StudentID,
    case 
        when exists (
            select 1
            from dbo.TakenCourses tc
            where tc.StudentID = s.StudentID 
            and tc.CourseID = p.PrereqID
        ) then 1  -- Prerequisite met
        else 0  -- Prerequisite not met
    end as PrereqMet
from dbo.Prereq p, 
     dbo.Student s
where s.Status = 'Active';
GO
