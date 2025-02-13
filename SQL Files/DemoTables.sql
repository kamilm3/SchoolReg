USE SchoolReg

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

--Chemistry teachers
('Bob', 'Fisher', 5, 'bobf@university.edu'),
('Anna', 'White', 5, 'annaw@university.edu'),

--Biology teachers
('Violet', 'Kane', 6, 'violetk@university.edu'),
('Cory', 'Jensen', 6, 'coryjensen@university.edu'),

--Math teachers
('Mary', 'West', 2, 'maryw@university.edu');

INSERT INTO Classroom (Location, Capacity) VALUES
('Building A, Room 101', 5),
('Building B, Room 202', 5),
('Building C, Room 303', 5),
('Building D, Room 404', 5),
('Building E, Room 205', 5),
('Building F, Room 200', 5),
('Building G, Room 301', 5),
('Building C, Room 305', 5),
('Building C, Room 310', 5); --Building B is math--

INSERT INTO DayOfWeek (DayID, DayName) VALUES
(0, 'Sunday'),
(1, 'Monday'),
(2, 'Tuesday'),
(3, 'Wednesday'),
(4, 'Thursday'),
(5, 'Friday'),
(6, 'Saturday');

-- Insert sample courses (no scheduling info here)
INSERT INTO Courses (CourseID, DepartmentID, InstructorID, ClassroomID, Credits, CourseName, Year, Term, CourseCode)
VALUES
(101, 1, 1, 1, 3, 'Introduction to Programming', 2025, 'Fall', 'CMPT101'),
(102, 1, 1, 2, 4, 'Data Structures', 2025, 'Fall', 'CMPT200'),
(103, 2, 2, 3, 3, 'Calculus I', 2025, 'Fall', 'MATH114'),
(104, 3, 3, 4, 4, 'Quantum Mechanics', 2026, 'Winter', 'PHYS372'),
(105, 4, 4, 1, 3, 'Principles of Management', 2026, 'Winter', 'MGMT101'),

--Chemistry--
(106, 5, 5, 5, 3, 'Introduction to Chemistry', 2025, 'Fall', 'CHEM101'),
(107, 5, 5, 5, 3, 'Organic Chemistry', 2026, 'Winter', 'CHEM252'),
(108, 5, 6, 6, 3, 'Organic Chemistry II', 2025, 'Fall', 'CHEM352'),
(109, 5, 6, 6, 3, 'Organometallic Chemistry', 2026, 'Winter', 'CHEM372'),

--Biology--
(110, 6, 7, 7, 3, 'Introduction to Cell Biology', 2025, 'Fall', 'BIOL101'),
(111, 6, 7, 7, 3, 'Principles of Molecular Biology', 2026, 'Winter', 'BIOL205'),
(112, 6, 8, 8, 3, 'Principles of Genetics', 2026, 'Winter', 'BIOL207'),

--Mathematics--
(113, 2, 2, 8, 3, 'Applied Linear Algebra', 2026, 'Winter', 'MATH103'),
(114, 2, 9, 9, 3, 'Intermediate Calculus', 2026, 'Winter', 'MATH214'),

--MGMT
  (115, 4, 4, 3, 3, 'Principles of Management', 2026, 'Fall', 'MGMT101'),
  (116, 4, 4, 4, 4, 'Marketing', 2026, 'Winter', 'MGMT201');

-- Insert CourseTimes for Tuesday & Thursday courses (90-minute sessions)
-- (Tuesday = DayID 2; Thursday = DayID 4)
INSERT INTO CourseTimes (CourseID, DayID, StartTimeMins, DurationMins)
VALUES
  -- Course 101: 9AM-10:30AM 540=60*9=9AM
  (101, 2, 540, 90),
  (101, 4, 540, 90),

  -- Course 103: 8AM-9:30AM 480=60*8=8AM
  (103, 2, 480, 90),
  (103, 4, 480, 90),

  -- Course 105: 11AM-12:30PM 660=60*11=11AM
  (105, 2, 660, 90),
  (105, 4, 660, 90),

  -- Course 107: 2PM-3:30PM 840=60*14=2PM
  (107, 2, 840, 90),
  (107, 4, 840, 90),

  -- Course 102: 10AM-11PM
  (102, 1, 600, 60),
  (102, 3, 600, 60),
  (102, 5, 600, 60),

  -- Course 104: 9AM-10AM 540=60*9=9AM
  (104, 1, 540, 60),
  (104, 3, 540, 60),
  (104, 5, 540, 60),

  -- Course 106: 8AM-9AM 480=60*8=8AM
  (106, 1, 480, 60),
  (106, 3, 480, 60),
  (106, 5, 480, 60),

  -- Course 108: 5PM-6PM 1020=60*17=5PM
  (108, 1, 1020, 60),
  (108, 3, 1020, 60),
  (108, 5, 1020, 60),

  (109, 2, 900, 90),
  (109, 4, 900, 90),

  -- Course 110: 10AM-11AM
  (110, 1, 600, 60),
  (110, 3, 600, 60),
  (110, 5, 600, 60),

  -- Course 111: 1PM-2PM
  (111, 1, 780, 60),
  (111, 3, 780, 60),
  (111, 5, 780, 60),

  -- Course 112: 4PM-5:30PM
  (112, 2, 960, 90),
  (112, 4, 960, 90),

  -- Course 113: 9AM-10AM
  (113, 1, 540, 60),
  (113, 3, 540, 60),
  (113, 5, 540, 60),

  -- Course 114: 11AM-12:30PM
  (114, 2, 660, 90),
  (114, 4, 660, 90),

  -- Course 115: 2PM-3PM
  (115, 1, 840, 60),
  (115, 3, 840, 60),
  (115, 5, 840, 60),

  -- Course 116: 3PM-4PM
  (116, 1, 900, 60),
  (116, 3, 900, 60),
  (116, 5, 900, 60);



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
--1 is not enrolled in anything to begin with
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
(20, 101),
(10, 106),
(10, 107),
(15, 110),
(15, 111);


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
(104, 103),  -- Quantum Mechanics requires Calculus I
(107, 106),  -- Organic Chemistry requires Introduction to Chemistry
(108, 107),  -- Organic Chemistry II requires Organic Chemistry
(109, 108),  -- Organomettalic Chemistry requires Organic Chemistry II
(111, 110),  -- Priniciples of Molecular Biology requires Introduction to Cell Biology
(112, 110),  -- Priniciples of Genetics requires Introduction to Cell Biology
(114, 103);  -- Intermediate Calculus requires Calculus I
