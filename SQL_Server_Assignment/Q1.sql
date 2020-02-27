create table Employee
( 
	emp_id int identity(4000,2) primary key,
	emp_name varchar(50),
	mobile bigint check(mobile between 6000000000 and 9999999999),
	dob date,
	zip_code int check(zip_code like replicate('[0-9]',6)),
	salary money,
	IsActive bit,
	CreatedDate datetime2,
	ModifiedDate datetime2
)

select * from Employee

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Neha Goel','7897897891','1995-08-07',110001,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Shagun Gupta','8376451093','1997-02-13',110043,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Sonal Jha','9287465199','1999-07-27',110043,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Punita Yadav','9992874651','2001-04-19',110076,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Latika','7782982746','1996-01-30',110009,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Vijay Kumar','8510037187','1995-11-22',110092,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Abhishek','6378640082','1998-09-25',110006,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Vishesh Kapoor','8899227651','1998-08-22',110025,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Arpit','6873790001','1996-09-29',110016,1,GETDATE(),GETDATE())

insert into Employee
(emp_name,mobile,dob,zip_code,IsActive,CreatedDate,ModifiedDate)
values('Azeem','8376451093','1996-01-15',110029,1,GETDATE(),GETDATE())

create table Salary
(
	emp_id int foreign key references Employee(emp_id),
	sal money
)

select * from Salary

insert into Salary
values(4018,9000)


select Employee.emp_id,Salary.sal
from Employee full outer join Salary on
Employee.emp_id=Salary.emp_id 
order by Employee.emp_id

select emp_id,sum(sal) as Salary_Sum,
count(emp_id) as no_of_months
from Salary
group by emp_id

update Employee
set 
Employee.salary=Salary.salary
from Employee inner join 
(select emp_id,sum(sal) as salary
from Salary 
group by emp_id) 
as salary on Employee.emp_id=Salary.emp_id

select * from Employee