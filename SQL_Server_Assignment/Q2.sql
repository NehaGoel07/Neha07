create table TBL_Employee
(
 emp_id int identity(101,1) primary key,
 emp_name varchar(MAX),
 sal money,
 dob datetime2
 )

 insert into TBL_Employee
 values('Neha',15100,'1995-08-07')

 insert into TBL_Employee
 values('Sonal',15000,'1997-07-27')

 select * from TBL_Employee



exec sp_rename 'TBL_Employee.dob','emp_dob'


