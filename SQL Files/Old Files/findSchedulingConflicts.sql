DECLARE  @CourseID INT;
DECLARE  @StudentID INT;
DECLARE  @Year INT;
DECLARE  @Term VARCHAR(10);

SET @CourseID = 101;
Set @StudentID = 1;
Set @Year = 2025;
Set @Term = 'Fall';


SELECT *
FROM CourseTimes newCT
WHERE newCT.CourseID = @CourseID

SELECT *
FROM Enroll e
JOIN Courses c ON e.CourseID = c.CourseID
WHERE e.StudentID = @StudentID
  AND c.Year = @Year
  AND c.Term = @Term

SELECT *
FROM CourseTimes oldCT
WHERE oldCT.CourseID IN (
      SELECT c.CourseID
      FROM Enroll e
      JOIN Courses c ON e.CourseID = c.CourseID
      WHERE e.StudentID = @StudentID
        AND c.Year = @Year
        AND c.Term = @Term
)


SELECT *
FROM CourseTimes newCT
WHERE newCT.CourseID = @CourseID
  AND EXISTS (
      SELECT 1
      FROM CourseTimes oldCT
      WHERE oldCT.CourseID IN (
            SELECT c.CourseID
            FROM Enroll e
            JOIN Courses c ON e.CourseID = c.CourseID
            WHERE e.StudentID = @StudentID
              AND c.Year = @Year
              AND c.Term = @Term
      )
      AND oldCT.DayID = newCT.DayID
      AND newCT.StartTimeMins < (oldCT.StartTimeMins + oldCT.DurationMins)
      AND (newCT.StartTimeMins + newCT.DurationMins) > oldCT.StartTimeMins
  )