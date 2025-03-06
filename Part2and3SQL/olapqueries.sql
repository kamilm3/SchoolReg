--gpt generated sample data
INSERT INTO DimCourses VALUES (1, 'Computer Science', 'Engineering', 'University A');
INSERT INTO DimInstructors VALUES (1, 'Dr. Smith', 'Engineering', 'Professor', 'University A');
INSERT INTO DimStudents VALUES (1, 'John Doe', 'Computer Science', 'Male');
INSERT INTO DimDate VALUES (1, 'Fall', 2024);
INSERT INTO FactCourseEnrollment VALUES (1, 1, 1, 1, 30);


--olap query ideas

--drill-down from uni to dept
SELECT University, Faculty, Department, COUNT(*) AS CourseCount
FROM DimCourses
GROUP BY University, Faculty, Department
ORDER BY University, Faculty, Department;

--roll-up (group by uni)
SELECT University, COUNT(*) AS TotalCourses
FROM DimCourses
GROUP BY University
ORDER BY TotalCourses DESC;

--course enrollment by instructor
SELECT Instructors.InstructorName, COUNT(Enroll.CourseID) AS CoursesTaught
FROM FactCourseEnrollment Enroll
JOIN DimInstructors Instructors ON Enroll.InstructorID = Instructors.InstructorID
GROUP BY Instructors.InstructorName;

--number of students enrolled in courses per year
SELECT DD.Year, Courses.Department, SUM(Enroll.EnrollmentCount) AS TotalEnrollments
FROM FactCourseEnrollment Enroll
JOIN DimDate DD ON Enroll.DateID = DD.DateID
JOIN DimCourses Courses ON Enroll.CourseID = Courses.CourseID
GROUP BY DD.Year, Courses.Department
ORDER BY DD.Year, Courses.Department;