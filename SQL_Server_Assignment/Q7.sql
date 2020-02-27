--self join
select * from TBL_Employee a,TBL_Employee b
where a.emp_id=b.emp_id;

--left join
select * from TBL_Employee left join emp
on TBL_Employee.emp_name=emp.emp_name

--left join showing only distinct data of tableA
select * from TBL_Employee left join emp
on TBL_Employee.emp_name=emp.emp_name
where emp.emp_name is null

--right join 
select * from emp right join TBL_Employee
on emp.emp_name=TBL_Employee.emp_name

--right join showing only distinct data of tableB
select * from emp right join TBL_Employee
on TBL_Employee.emp_name=emp.emp_name
where TBL_Employee.emp_name is null

--inner join
select * from TBL_Employee join emp
on TBL_Employee.emp_name=emp.emp_name