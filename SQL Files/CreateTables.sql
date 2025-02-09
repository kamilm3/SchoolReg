USE SchoolReg

DROP TABLE IF EXISTS Enroll;
DROP TABLE IF EXISTS TakenCourses;
DROP TABLE IF EXISTS ShoppingCart;
DROP TABLE IF EXISTS Prereq;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Student;
DROP TABLE IF EXISTS Instructor;
DROP TABLE IF EXISTS Classroom;
DROP TABLE IF EXISTS Department;

CREATE TABLE Department (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    Field VARCHAR(255)
);

CREATE TABLE Instructor (
    InstructorID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Department(DepartmentID),
    Email VARCHAR(100)
);

CREATE TABLE Classroom (
    ClassroomID INT PRIMARY KEY IDENTITY(1,1),
    Location VARCHAR(255),
    Capacity INT
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    DepartmentID INT FOREIGN KEY REFERENCES Department(DepartmentID),
    InstructorID INT FOREIGN KEY REFERENCES Instructor(InstructorID),
    ClassroomID INT FOREIGN KEY REFERENCES Classroom(ClassroomID),
    Credits INT,
    CourseName VARCHAR(255),
);

CREATE TABLE Student (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentID INT FOREIGN KEY REFERENCES Department(DepartmentID),
    DOB DATE,
    Email VARCHAR(100),
    FirstName VARCHAR(50),
    LastName VARCHAR(50)
);

CREATE TABLE Enroll (
    StudentID INT,
    CourseID INT,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE TakenCourses (
    StudentID INT,
    CourseID INT,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE ShoppingCart (
    CartID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT FOREIGN KEY REFERENCES Student(StudentID),
    CourseID INT FOREIGN KEY REFERENCES Courses(CourseID),
    Time DATETIME
);

CREATE TABLE Prereq (
    CourseID INT,
    PrereqID INT,
    PRIMARY KEY (CourseID, PrereqID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE,
    FOREIGN KEY (PrereqID) REFERENCES Courses(CourseID) ON DELETE NO ACTION
);
