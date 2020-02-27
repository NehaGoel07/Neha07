--views creates a virtual table of an existing table based on some condition.It represents consistent data.If data is inserted using view all the constraints are checked automatically by the DBMS.

create view SampleView as
select emp_id,emp_name,sal
from TBL_Employee
where sal>=15000

select * from SampleView