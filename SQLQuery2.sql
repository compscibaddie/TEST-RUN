CREATE DATABASE BelgiumCampus;
GO

USE BelgiumCampus;
GO
CREATE TABLE Students
( StudentID INT PRIMARY KEY ,
	Name VARCHAR (60),
	Surname VARCHAR (60),
	Course VARCHAR (20)
)

CREATE TABLE Lecturers
(	EmpID INT PRIMARY KEY,
	Name VARCHAR(50),
	Surname VARCHAR (50),
	Qualification VARCHAR (20)
)

INSERT INTO Students 
VALUES (2937, 'John', 'Red', 'Diploma'),
		(2257, 'Susan', 'Grey', 'Degree'),
		(2597, 'Andrew', 'Yellow', 'Diploma'),
		(2934, 'Mark', 'Blue', 'Degree'),
		(2935, 'Sarah', 'Green', 'Diploma');

INSERT INTO Lecturers 
VALUES (456, 'Simba', 'Amber', 'Masters'),
		(257, 'Anila', 'Maroon', 'PHD'),
		(597, 'Themba', 'Black', 'Masters'),
		(934, 'Mark', 'Fish', 'Degree'),
		(235, 'Jane', 'Pink', 'Masters');
