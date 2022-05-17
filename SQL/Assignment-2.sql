use Assignment

select * from EMP
select * from DEPT

--1. Retrieve a list of MANAGERS. 
select * from EMP where job = 'Manager'

--2. Find out salary of both MILLER and SMITH. 
select ename, sal from EMP where ename = 'Miller' or ename = 'Smith'

--3. Find out the names and salaries of all employees earning more than 1000 per month.
select ename, sal from EMP where sal > 1000

--4. Display the names and salaries of all employees except JAMES.
select ename, sal from EMP where ename != 'James'

--5. Find out the details of employees whose names begin with ‘S’. 
select * from EMP where ename like 'S%'

--6. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename from EMP where ename like '%a%'

--7. Find out the names of all employees that have ‘L’ as their third character in their name.
select ename from EMP where ename like '__L%'

--8. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename from EMP where ename like 'A%' or ename like 'M%' 

--9. Compute yearly salary of SMITH. 
select ename, sal*12 as Yearly_sal from EMP where ename = 'Smith'

--10. Compute daily salary of JONES.
select ename, sal/28 as Daily_sal from EMP where ename = 'Jones'

--11. Calculate the total monthly salary of all employees.
select sum(sal) as Total_Monthly_sal from EMP

--12. Print the average annual salary. 
select avg(sal * 12) as avg_annual_sal from EMP

--13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select ename, job, sal, Did from EMP where Did = 30 and job != 'Salesman'

--14. List unique departments of the EMP table. 
select Did from EMP group by Did

--15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename, sal, Did from EMP where sal > 1500 and Did =10 or Did = 30