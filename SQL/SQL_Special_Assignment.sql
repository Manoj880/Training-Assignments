create database SQL_Spcl_Assignment

use SQL_Spcl_Assignment

-- Creating Client Table

create table Clients
(Client_ID int primary key, Cname nvarchar(40) not null, Adress nvarchar(30), Email nvarchar(30) unique, Phone bigint,
Business nvarchar(20) not null)

-- Inserting data into clients table
insert into Clients
values(1100, 'Skylark Corp','Delhi', 'admin@skylark.com',1800265689,'Reseller'),
(1101, 'Oscorp', 'New York','Professional@oscorp.com',3249479515,'Professional'),
(1102,'Stark Tech', 'DC','mfg@starktech.com',6833456982,'Manufacturer'),
(1103,'SMR Consultants','Andhra Pradesh','consultant@smr.com',9000643819,'Consultant')

select * from Clients

-- Creating Employee table

create table Employees
(Empno int primary key, Ename nvarchar(20) not null, Job nvarchar(15), Salary float check(Salary>0),
Deptno int foreign key references Department(Deptno))

-- Inserting Employee details into table

insert into Employees
values(57501,'Sandhya','Developer',28500,111),
(57502,'Manoj','Developer',40000,111),
(57503,'Raja Sri','Designer',26000,101),
(57504,'Sunny','Designer',28500,101),
(57505,'Ramya','Tester',26500,121),
(57506,'Devadas','Production Mgr',30000,131),
(57507,'Anudeep','Analyst',28500,101),
(57508,'Radha','Designer',30000,101),
(57509,'Abhiya','Tester',33000,121),
(57510,'Sumathi','QA Mgr',34000,121)

select * from Employees


-- Creating Department table

create table Department
(Deptno int primary key, Dname nvarchar(20) not null, Locationn nvarchar(20))

-- Inserting data into Deparment table

insert into Department
values(101,'Design','Hyderabad'),
(111,'Development','Mumbai'),
(121,'QA','Bangalore'),
(131,'Production','Kolkata')

select * from Department

-- Creating Projects table

create table project
(Project_ID int primary key, Descr nvarchar(30) not null, Start_Date_ Date, Planned_End_Date Date,
Actual_End_Date Date, check (Actual_End_Date > Planned_End_Date))

-- Inserting Data into Project table

insert into project
values(201,'Accounting','19-Sep-2012','19-Apr-2013','05-May-2013'),
(202,'Payroll','27-Apr-2012','19-Sep-2012','08-Oct-2012'),
(203,'IT Mgmt','21-Mar-2012','22-Aug-2012','22-Nov-2012'),
(204,'Inventory','24-Nov-2012','22-May-2013','10-Jun-2013')

select * from Project


-- Creating ProjectTask Table

create table ProjectTask
(Project_ID int foreign key references Project(Project_ID),
Empno int foreign key references Employees(Empno),
primary key(Empno,Project_ID), Task nvarchar(30) not null,
Start_Date_ date, End_Date date, Prj_Status nvarchar(15) not null)

-- Inserting Data into ProjectTask Table
insert into ProjectTask
values(202,57501,'Coding','27-Apr-2012','19-Sep-2012','Completed'),
(202,57502,'Coding','27-Apr-2012','19-Sep-2012','Completed'),
(202,57503,'System Design','27-Apr-2012','19-Sep-2012','Completed'),
(204,57505,'System Tester','24-Nov-2012','22-May-2013','Completed'),
(204,57504,'System Design','24-Nov-2012','22-May-2013','Completed'),
(203,57506,'Production Engg','21-Mar-2012','22-Aug-2012','Completed'),
(203,57502,'Coding','21-Mar-2012','22-Aug-2012','Completed'),
(203,57508,'System Design','21-Mar-2012','22-Aug-2012','Completed'),
(201,57509,'Testing','19-Sep-2012','19-Apr-2013','In Progress'),
(201,57510,'QA Mgmt','19-Sep-2012','19-Apr-2013','In Progress'),
(204,57507,'System Analysis','24-Nov-2012','22-May-2013','Completed')

select * from ProjectTask