


--dimension tables
CREATE TABLE DimStudents (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(50),
    Major VARCHAR(50),
    Gender VARCHAR(10)
);

CREATE TABLE DimCourses (
    CourseID INT PRIMARY KEY,
    Department VARCHAR(100),
    Faculty VARCHAR(80),
    University VARCHAR(60)
);

CREATE TABLE DimInstructors (
    InstructorID INT PRIMARY KEY,
    InstructorName VARCHAR(50),
    Faculty VARCHAR(80),
    Rank VARCHAR(50),
    University VARCHAR(60)
);

CREATE TABLE DimDate (
    DateID INT PRIMARY KEY,
    Semester VARCHAR(20),
    Year INT
);

--fact table
CREATE TABLE FactCourseEnrollment (
    CourseID INT, -- column that links to DimCourses --type: INT (PK,FK)
    InstructorID INT, --links to DimInstructors --INT(FK)
    StudentID INT, --links to DimStudents --INT(FK)
    DateID INT, -- links to DimDate --INT(FK)
    EnrollmentCount INT, -- num of students in a course
    PRIMARY KEY (CourseID, InstructorID, StudentID, DateID),
    FOREIGN KEY (CourseID) REFERENCES DimCourses(CourseID),
    FOREIGN KEY (InstructorID) REFERENCES DimInstructors(InstructorID),
    FOREIGN KEY (StudentID) REFERENCES DimStudents(StudentID),
    FOREIGN KEY (DateID) REFERENCES DimDate(DateID)
);