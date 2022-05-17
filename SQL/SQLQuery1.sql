--String unctions
select lower('HELLO WORLD')
select upper('hello world')
select replace('jack and jill','j','bl')
select substring('This is SQL Query Command',9,9)
select ascii('b')
select concat('Happy ','Birthday ','To ','You ','17')

select * from Employee

create or alter proc sp_details(@did int)
as 
begin
select employee.*,Department.DeptName from Employee join Department on Employee.Did=Department.DeptID
where Department.DeptID = @did
end
exec sp_details 3

create or alter proc sp_taxcalculator
(@id int, @annualsalary float output, @ename varchar(20) output)
as
begin
declare @temp float
select @ename from EmpName where EmpID = @id
select @temp = (salary * 12) from Employee where EmpID = @id
if (@temp > 336000)
begin
set @annualsalary = @temp * 0.1
end
else
print @annualsalary = @temp * 0.05
end
declare @Totaltax float
declare @name varchar(20)
exec sp_calculator @id = 1001, @Totaltax output, @name output
print @ total tax
print @name
select concat(@name,'has to pay a tax amount of ', @Totaltax)  
  