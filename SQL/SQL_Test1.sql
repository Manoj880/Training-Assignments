create database CodeBaseTEST

select DATEDIFF(dd,'1999/09/19','2022/05/17') AS Date_of_Birth_In_Days

create table EMP8
(EmpId int primary key, name varchar(30), salary float, Deptno int)

insert into EMP8
values
(1001,'Manoj',25000,10),
(1002,'Sunny',24000,20),
(1003,'Sandhya',28000,30),
(1004,'Hari',26000,30)
select * from EMP8

alter table EMP8 add constraint salchk check (salary between 5000 and 5000)