----table valued function
create function GetEmployeeDetails(@emp_id int)
returns table
as
return 
select * from TBL_Employee where emp_id=@emp_id

--scalar function
create function GetEmp(@emp_id int)
returns varchar(50)
as
begin
return(select emp_name from TBL_Employee where emp_id=@emp_id)
end

--executing table valued function
select * from GetEmployeeDetails(101)

--executing scalar function
PRINT dbo.GetEmp(102)
