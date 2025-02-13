USE SchoolReg

INSERT INTO Department (Field) VALUES 
('Computer Science'),
('Mathematics'),
('Physics'),
('Business');

INSERT INTO Instructor (FirstName, LastName, DepartmentID, Email) VALUES
('John', 'Doe', 1, 'johndoe@university.edu'),
('Jane', 'Smith', 2, 'janesmith@university.edu'),
('Robert', 'Johnson', 3, 'robertj@university.edu'),
('Emily', 'Clark', 4, 'emilyc@university.edu');

INSERT INTO Classroom (Location, Capacity) VALUES
('Building A, Room 101', 5),
('Building B, Room 202', 5),
('Building C, Room 303', 5),
('Building D, Room 404', 5);

INSERT INTO DayOfWeek (DayID, DayName) VALUES
(0, 'Sunday'),
(1, 'Monday'),
(2, 'Tuesday'),
(3, 'Wednesday'),
(4, 'Thursday'),
(5, 'Friday'),
(6, 'Saturday');

INSERT INTO Courses (CourseID, DepartmentID, InstructorID, ClassroomID, Credits, CourseName, Year, Term, CourseCode, StartTimeMins, DurationMins, DayOfWeek) VALUES
(101, 1, 1, 1, 3, 'Introduction to Programming', 2025, 'Fall', 'CMPT101', 1000, 90, 1),
(102, 1, 1, 2, 4, 'Data Structures', 2025, 'Fall', 'CMPT200', 1300, 90, 2),
(103, 2, 2, 3, 3, 'Calculus I', 2025, 'Fall', 'MATH114', 900, 60, 3),
(104, 3, 3, 4, 4, 'Quantum Mechanics', 2026, 'Winter', 'PHYS372', 1400, 120, 4),
(105, 4, 4, 1, 3, 'Principles of Management', 2026, 'Winter', 'MGMT101', 1530, 90, 1);

INSERT INTO Student (DepartmentID, DOB, Email, FirstName, LastName) VALUES
(1, '2002-04-15', 'alice@university.edu', 'Alice', 'Brown'),
(2, '2001-06-20', 'bob@university.edu', 'Bob', 'White'),
(3, '2003-01-10', 'charlie@university.edu', 'Charlie', 'Green'),
(4, '2002-09-05', 'diana@university.edu', 'Diana', 'Black'),
(1, '2003-08-14', 'lucas@university.edu', 'Lucas', 'Perez'),
(1, '2002-12-22', 'amelia@university.edu', 'Amelia', 'Gonzalez'),
(2, '2001-03-05', 'henry@university.edu', 'Henry', 'Hall'),
(2, '2003-06-17', 'harper@university.edu', 'Harper', 'Allen'),
(3, '2000-09-28', 'elijah@university.edu', 'Elijah', 'Scott'),
(3, '2004-01-11', 'evelyn@university.edu', 'Evelyn', 'Rivera'),
(4, '2002-10-02', 'alexander@university.edu', 'Alexander', 'Carter'),
(4, '2003-05-25', 'abigail@university.edu', 'Abigail', 'Mitchell'),
(1, '2001-11-30', 'william@university.edu', 'William', 'Adams'),
(1, '2004-07-07', 'ava@university.edu', 'Ava', 'Nelson'),
(2, '2002-02-14', 'jackson@university.edu', 'Jackson', 'Baker'),
(2, '2003-12-05', 'sofia@university.edu', 'Sofia', 'Roberts'),
(3, '2002-06-28', 'michael@university.edu', 'Michael', 'Hernandez'),
(3, '2004-09-15', 'grace@university.edu', 'Grace', 'Campbell'),
(4, '2001-03-18', 'oliver@university.edu', 'Oliver', 'Garcia'),
(4, '2002-08-22', 'chloe@university.edu', 'Chloe', 'Rodriguez'),
(1, '2003-01-10', 'nathan@university.edu', 'Nathan', 'Martinez'),
(2, '2004-11-14', 'zoe@university.edu', 'Zoe', 'Lee'),
(3, '2001-05-20', 'jacob@university.edu', 'Jacob', 'Lopez'),
(4, '2002-04-29', 'lily@university.edu', 'Lily', 'Harris');

INSERT INTO Enroll (StudentID, CourseID) VALUES
(1, 101),
(1, 102),
(2, 103),
(3, 104),
(4, 105),
(5, 101),
(6, 102),
(7, 103),
(8, 104),
(9, 105),
(10, 101),
(11, 103),
(12, 104),
(13, 102),
(14, 105),
(15, 101),
(16, 103),
(17, 104),
(18, 102),
(19, 105),
(20, 101);

INSERT INTO TakenCourses (StudentID, CourseID) VALUES
(1, 101),
(2, 103),
(3, 104),
(5, 101),
(6, 102),
(7, 103),
(8, 104),
(9, 105),
(10, 101),
(11, 103),
(12, 104),
(13, 102),
(14, 105);

INSERT INTO ShoppingCart (StudentID, CourseID, Time) VALUES
(5, 102, GETUTCDATE()),
(6, 104, GETUTCDATE()),
(7, 105, GETUTCDATE()),
(8, 101, GETUTCDATE()),
(9, 103, GETUTCDATE()), 
(10, 104, GETUTCDATE()),
(11, 102, GETUTCDATE()),
(12, 105, GETUTCDATE()),
(13, 101, GETUTCDATE()),
(14, 103, GETUTCDATE());

INSERT INTO Prereq (CourseID, PrereqID) VALUES
(102, 101),  -- Data Structures requires Introduction to Programming
(104, 103);  -- Quantum Mechanics requires Calculus I
