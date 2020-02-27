create table emp
(
emp_name varchar(MAX),
emp_dob date
)

select * from emp

insert into emp(emp_name,emp_dob)
select emp_name,emp_dob
from TBL_Employee