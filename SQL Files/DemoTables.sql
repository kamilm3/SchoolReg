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
('Building A, Room 101', 30),
('Building B, Room 202', 40),
('Building C, Room 303', 50),
('Building D, Room 404', 60);


INSERT INTO Courses (CourseID, DepartmentID, InstructorID, ClassroomID, Credits, CourseName) VALUES
(101, 1, 1, 1, 3, 'Introduction to Programming'),
(102, 1, 1, 2, 4, 'Data Structures'),
(103, 2, 2, 3, 3, 'Calculus I'),
(104, 3, 3, 4, 4, 'Quantum Mechanics'),
(105, 4, 4, 1, 3, 'Principles of Management');

INSERT INTO Student (DepartmentID, DOB, Email, FirstName, LastName) VALUES
(1, '2002-04-15', 'alice@university.edu', 'Alice', 'Brown'),
(2, '2001-06-20', 'bob@university.edu', 'Bob', 'White'),
(3, '2003-01-10', 'charlie@university.edu', 'Charlie', 'Green'),
(4, '2002-09-05', 'diana@university.edu', 'Diana', 'Black');

INSERT INTO Enroll (StudentID, CourseID) VALUES
(1, 101),
(1, 102),
(2, 103),
(3, 104),
(4, 105);

INSERT INTO TakenCourses (StudentID, CourseID) VALUES
(1, 101),
(2, 103),
(3, 104);

INSERT INTO ShoppingCart (StudentID, CourseID, Time) VALUES
(1, 102, GETDATE()),
(2, 104, GETDATE()),
(3, 105, GETDATE());

INSERT INTO Prereq (CourseID, PrereqID) VALUES
(102, 101),  -- Data Structures requires Introduction to Programming
(104, 103);  -- Quantum Mechanics requires Calculus I


select *
from Classroom