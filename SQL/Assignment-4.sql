use Assignment

/*1.	Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a)	HRA  as 10% Of sal
b)	DA as  20% of sal
c)	PF as 8% of sal
d)	IT as 5% of sal
e)	Deductions as sum of PF and IT
f)	Gross Salary as sum of SAL,HRA,DA and Deductions
g)	Net salary as  Gross salary- Deduction. */

begin
declare @salary int = 28500
declare @HRA float, @DA float, @PF float, @IT float, @Deductions float, @Gross_Salary float, @Net_Salary float

--a). HRA  as 10% Of sal
set @HRA = (@salary * 0.1)
print 'HRA Tax is: ' +cast(@HRA as nvarchar(8))

--b). DA as  20% of sal
set @DA = @salary * 0.2
print 'DA Tax is: ' +cast(@DA as nvarchar(8))

--c). PF as 8% of sal
set @PF = @salary * 0.08
print 'PF Tax is: ' +cast(@PF as nvarchar(8))


--d). IT as 5% of sal
set @IT = @Salary * 0.05
print 'IT Tax is: '+cast(@IT as nvarchar(8))


--e). Deductions as sum of PF and IT
set @Deductions = @PF + @IT
print 'Deductions from salary is: ' +cast(@Deductions as nvarchar(8))

--f). Gross Salary as sum of SAL,HRA,DA and Deductions
set @Gross_Salary = @salary + @HRA + @DA
print 'Gross Salary is: ' +cast(@Gross_Salary as nvarchar(8))

--g). Net salary as  Gross salary- Deduction. 
set @Net_Salary = @Gross_Salary - @Deductions
print 'Net Salary is: ' +cast (@Net_Salary as nvarchar(8))
end

--2. Write a T-SQL Program to find the factorial of a given number.

begin
declare @Factorial int 
declare @number int 
set @Factorial = 1
set @Number = 6
while @number>0
begin
set @factorial = @number * @factorial
set @number = @number-1
end
print 'Factorial of given number is: '+ cast(@Factorial as nvarchar(8))
end

/* 3.  	Create a stored procedure to generate multiplication tables up to a given number.
 (Hint : if number is 5, then 5*1=5 
                             5*2=10...
                             5*10=50) */

create or alter proc Multiplication_Table (@num1 int)
as
begin 
declare @num2 int =1
declare @ans int

While(@num2<=10)
begin
set @ans =  @num1 * @num2
print  @ans
set @num2 = @num2+1
end
end

exec Multiplication_Table @num1 = 2
