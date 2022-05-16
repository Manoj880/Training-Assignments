create database Assignment
--Creating Department table
create table DEPT
(
Deptno int primary key,
Dname varchar(20),
Loc varchar(20)
)
drop table DEPT
--Inserting values to Department table
insert into DEPT
values(10,'Accounting','New York'),(20,'Research','Dallas'),(30,'Sales','Chicago'),(40,'Operations','Boston')
select * from DEPT
--creating EMP table
create table EMP
(
empno int primary key,
ename varchar(20),
job varchar(15),
mgr int ,
hiredate date,
sal float,
comm float,
Did int foreign key references DEPT(Deptno)
)
drop table EMP
--Inserting values to Employee table
insert into EMP
values(7369,'Smith','Clerk', 7902,'1980-12-17', 800, null, 20),
(7499,'Allen','Salesman', 7698, '1981-02-20', 1600, 300, 30),
(7521,'Ward','Salesman', 7698, '1981-02-22', 1250, 500, 30),
(7566,'Jones','Manager', 7839, '1981-04-02', 2975, null, 20),
(7654,'Martin','Salesman', 7698, '1981-09-28', 1250, 1400, 30),
(7698,'Blake','Manager', 7839, '1981-05-01', 2850, null, 30),
(7782,'clark','Manager', 7839, '1981-06-09', 2450, null, 10),
(7788,'Scott','Analyst', 7566, '1987-04-19', 3000, null, 20),
(7839,'King','President', null, '1981-11-17', 5000, null, 10),
(7844,'Turner','Salesman', 7698, '1981-09-08', 1500, 0, 30),
(7876,'Adams','Clerk', 7788, '1987-05-23', 1100, null, 20),
(7900,'James','Clerk', 7698, '1981-12-03', 950, null, 30),
(7902,'Ford','Analyst', 7566, '1981-12-03', 3000, null, 20),
(7934,'Miller','Clerk', 7782, '1982-01-23', 1300, null,10)
select * from EMP

--Queries
--1. List all employees whose name begins with 'A'. 
select * from EMP where ename like 'A%'

--2. Select all those employees who don't have a manager. 
select * from EMP where job != 'Manager'

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select ename,empno,sal from EMP where sal between 1200 and 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
select ename,sal,did, sal+sal*0.1 as '10% Pay rise' from EMP
where Did in (select Deptno from DEPT where DName ='Research') 

--5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) No_Of_Clerks from EMP
where job='Clerk'

--6. Find the average salary for each job type and the number of people employed in each job. 
select count(*) no_of_People_employed_in_each_job, avg(sal) as avg_sal from EMP
group by job

--7. List the employees with the lowest and highest salary. 
select max(sal) as Max_sal, min(sal) as Min_sal from EMP

--8. List full details of departments that don't have any employees.
select * from DEPT where deptno not in (select Did from EMP)

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name.
select ename,sal from EMP where job='Analyst' and sal > 1200 and Did = 20
order by ename asc

--10. For each department, list its name and number together with the total salary paid to employees in that department.
select job, Did, sum(sal) Total_Sal from EMP
group by job,Did

--11. Find out salary of both MILLER and SMITH.
select ename, sal from EMP
where ename in('miller','Smith')

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
select * from EMP where ename like 'A%' or ename like 'M%' 

--13. Compute yearly salary of SMITH
select ename, sal*12 Yearly_sal from EMP
where ename = 'Smith'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select ename, sal from EMP 
where sal not between 1500 and 2850
