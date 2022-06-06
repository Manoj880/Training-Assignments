create database Casestudy

use Casestudy 

--Creating student table

Create table student
(studentID int primary key,
StudentName varchar(30),
DOB varchar(15))

select * from student

drop table student
--Creating course table

Create table course
(CourseId int primary key,
Coursename varchar(15),
CourseDuration int,
CourseFee float)

select * from course

drop table course

--Creating Enroll table

Create table Enroll
(studentID int,
CourseID int,
Foreign key (studentID) references student(StudentID),
foreign key (CourseID) references course(CourseId),
DateOfEroll varchar(20))

selEct * from Enroll


drop table enroll
