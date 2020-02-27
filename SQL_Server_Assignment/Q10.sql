--Returning a value is optional in Stored Procedures.It can have both input and output parameters.Procedusres can call functions but functions cannot call procedures.
--It is compulsory for a function to return a value.It can only have input parameters.

--creating procedures
create procedure usp_JustAnExample(@emp_id int)
as
begin
select * from TBL_Employee where emp_id=@emp_id
end
--executing procedure
exec usp_JustAnExample @emp_id=104

--creating function
create function GetDetails(@emp_id int)
returns table
as
return 
select * from TBL_Employee where emp_id=@emp_id

--executing function
select * from GetDetails(102)
