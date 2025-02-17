USE SchoolReg;

DROP VIEW IF EXISTS vwEnrollCapacity;

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
    Field VARCHAR(255) NOT NULL
);

CREATE TABLE Instructor (
    InstructorID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DepartmentID INT NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);

CREATE TABLE Classroom (
    ClassroomID INT PRIMARY KEY IDENTITY(1,1),
    Location VARCHAR(255) NOT NULL,
    Capacity INT
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    DepartmentID INT NOT NULL,
    InstructorID INT NOT NULL,
    ClassroomID INT NOT NULL,
    Credits INT,
    CourseName VARCHAR(255) NOT NULL,
    Year INT NOT NULL,
    Term VARCHAR(10) NOT NULL,
    CourseCode VARCHAR(10) NOT NULL,
    DayOfWeek VARCHAR(9) NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID),
    FOREIGN KEY (InstructorID) REFERENCES Instructor(InstructorID),
    FOREIGN KEY (ClassroomID) REFERENCES Classroom(ClassroomID)
);

CREATE TABLE Student (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentID INT NOT NULL,
    DOB DATE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Status VARCHAR(10),
    FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);

CREATE TABLE Enroll (
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE TakenCourses (
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE ShoppingCart (
    CartID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    Time DATETIME DEFAULT GETDATE(),
    CONSTRAINT UniqueShoppingCartStudentIDCourseID UNIQUE (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE Prereq (
    CourseID INT NOT NULL,
    PrereqID INT NOT NULL,
    PRIMARY KEY (CourseID, PrereqID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE,
    FOREIGN KEY (PrereqID) REFERENCES Courses(CourseID) ON DELETE NO ACTION
);
