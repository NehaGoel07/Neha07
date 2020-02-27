--first procedure
create procedure usp_InsertEmp
(@emp_name varchar(50),@emp_dob date)
as
begin
insert into emp(emp_name,emp_dob) values(@emp_name,@emp_dob)
select * from emp
end

--second procedure
create procedure usp_InvokeFirst
(@Semp_name varchar(50),@Semp_dob date)
as 
begin
exec usp_InsertEmp @emp_name=@Semp_name,@emp_dob=@Semp_dob
end

--executing second stored procedure
exec usp_InvokeFirst @Semp_name='Shagun',@Semp_dob='1997-02-13'