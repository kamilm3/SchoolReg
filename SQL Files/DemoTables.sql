USE SchoolReg;

INSERT INTO Department (Field) VALUES 
('Computer Science'),
('Mathematics'),
('Physics'),
('Business'), 
('Chemistry'),
('Biology');

INSERT INTO Instructor (FirstName, LastName, DepartmentID, Email) VALUES
('John', 'Doe', 1, 'johndoe@university.edu'),
('Jane', 'Smith', 2, 'janesmith@university.edu'),
('Robert', 'Johnson', 3, 'robertj@university.edu'),
('Emily', 'Clark', 4, 'emilyc@university.edu'),
('Bob', 'Fisher', 5, 'bobf@university.edu'),
('Anna', 'White', 5, 'annaw@university.edu'),
('Violet', 'Kane', 6, 'violetk@university.edu'),
('Cory', 'Jensen', 6, 'coryjensen@university.edu'),
('Mary', 'West', 2, 'maryw@university.edu');

INSERT INTO Classroom (Location, Capacity) VALUES
('Building A, Room 101', 3), -- Small class for capacity testing
('Building B, Room 202', 5),
('Building C, Room 303', 10),
('Building D, Room 404', 5),
('Building E, Room 205', 5),
('Building F, Room 200', 5);

INSERT INTO Courses (CourseID, DepartmentID, InstructorID, ClassroomID, Credits, CourseName, Year, Term, CourseCode, DayOfWeek, StartTime, EndTime, EnrolledStudents)
VALUES
(101, 1, 1, 1, 3, 'Introduction to Programming', 2025, 'Fall', 'CMPT101', 'Monday', '09:00:00', '10:30:00', 2),
(102, 1, 1, 2, 4, 'Data Structures', 2025, 'Fall', 'CMPT200', 'Monday', '09:30:00', '11:00:00', 0), -- Overlaps with CMPT101
(103, 2, 2, 3, 3, 'Calculus I', 2025, 'Fall', 'MATH114', 'Tuesday', '08:30:00', '10:00:00', 1),
(104, 3, 3, 4, 4, 'Quantum Mechanics', 2026, 'Winter', 'PHYS372', 'Thursday', '11:00:00', '12:30:00', 0),
(105, 4, 4, 1, 3, 'Principles of Management', 2026, 'Winter', 'MGMT101', 'Friday', '14:00:00', '15:30:00', 1),

-- Courses with prerequisites
(106, 5, 5, 5, 3, 'Introduction to Chemistry', 2025, 'Fall', 'CHEM101', 'Wednesday', '10:00:00', '11:30:00', 0),
(107, 5, 5, 5, 3, 'Organic Chemistry', 2026, 'Winter', 'CHEM252', 'Wednesday', '12:00:00', '13:30:00', 0), -- Requires CHEM101
(108, 6, 7, 6, 3, 'Introduction to Cell Biology', 2025, 'Fall', 'BIOL101', 'Tuesday', '14:00:00', '15:30:00', 1),
(109, 6, 8, 6, 3, 'Principles of Genetics', 2026, 'Winter', 'BIOL207', 'Tuesday', '16:00:00', '17:30:00', 0); -- Requires BIOL101

INSERT INTO Student (DepartmentID, DOB, Email, FirstName, LastName, Status) VALUES
(1, '2002-04-15', 'alice@university.edu', 'Alice', 'Brown', 'Active'),
(2, '2001-06-20', 'bob@university.edu', 'Bob', 'White', 'Active'),
(3, '2003-01-10', 'charlie@university.edu', 'Charlie', 'Green', 'Active'),
(4, '2002-09-05', 'diana@university.edu', 'Diana', 'Black', 'Active'),
(5, '2001-11-30', 'william@university.edu', 'William', 'Adams', 'Active'),
(5, '2001-12-31', 'fred@university.edu', 'Fred', 'Alfred', 'NonActive');

INSERT INTO Prereq (CourseID, PrereqID) VALUES
(107, 106),  -- Organic Chemistry requires Introduction to Chemistry
(109, 108);  -- Principles of Genetics requires Introduction to Cell Biology

INSERT INTO Enroll (StudentID, CourseID) VALUES
-- (1, 101), Conflict (Same day/time as CMPT101)
(2, 103), -- Allowed
(3, 105), -- Allowed
(5, 108), -- Allowed
(5, 101), -- Allowed
(4, 101); -- Allowed


INSERT INTO TakenCourses (StudentID, CourseID) VALUES
(4, 106), -- Student 4 has completed Introduction to Chemistry
(5, 108), -- Student 5 has completed Introduction to Cell Biology
(6, 108); -- Student 6 has completed Introduction to Cell Biology but NonActive

INSERT INTO ShoppingCart (StudentID, CourseID) VALUES
-- (2, 102),  Conflict (Same time as CMPT101)
(3, 105); -- Allowed
-- (4, 107), Should fail (Prereq CHEM101 required)
-- (5, 112); Should fail (Prereq BIOL101 required)

