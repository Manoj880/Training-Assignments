use Assignment

select * from EMP
select * from DEPT

--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename, sal from EMP where sal not between 1500 and 2850

--2. Display the name and job of all employees who do not have a MANAGER. 
select ename, job from emp where mgr is null

--3. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000.
select ename, job, sal from EMP where (job = 'Manager' or job ='Analyst') and sal not in (1000, 3000, 5000)

--4. Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%. 
select ename, sal, comm from EMP where comm > sal+sal*0.1

--5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select ename from EMP where ename like '%ll%' and Did = 30 or mgr =7782

--6. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees.
update EMP set hiredate = '2009-09-19' where empno in (7844,7566)

select count(*) No_of_Employees, ename from EMP 
where convert (nvarchar(3),datediff(year,hiredate,getdate())) > 10 and
convert(nvarchar(3),datediff(year,hiredate,getdate())) < 20 
group by ename

--7. Retrieve the names of departments in ascending order and their employees in descending order.
select Dname, ename, Did from EMP join DEPT on EMP.Did = DEPT.Deptno 
order by Dname asc, ename desc

--8. Find out experience of MILLER.
select convert (nvarchar(3),datediff(year,hiredate,getdate())) as Exp_of_Miller
from EMP where ename = 'Miller'

--9. How many different departments are there in the employee table. 
select Dname, count(*) Diff_Depts from EMP join DEPT on EMP.Did = DEPT.Deptno group by Dname

--10. Find out which employee either work in SALES or RESEARCH department. 
select ename, Dname from EMP join DEPT on EMP.Did = DEPT.Deptno 
where Dname = 'Research' or Dname = 'Sales'

--11. Print the name and average salary of each department.
select Dname, avg(sal) Avg_Salary from EMP join DEPT on EMP.Did = DEPT.Deptno
group by Dname

--12. Select the minimum and maximum salary from employee table. 
select min(sal) Min_Salary, max(sal) Max_Salary from EMP

--13. Select the minimum and maximum salaries from each department in employee table. 
select min(sal) Min_Salary, max(sal) Max_Salary from EMP
group by Did

--14. Select the details of employees whose salary is below 1000 and job is CLERK. 
select * from EMP where sal < 1000 and job = 'Clerk'
