--where clause
--where clause do not work with aggregate functions.where is used before group by clause.It acts like a pre filter.
select * from TBL_Employee
where sal>=15000

--having clause
--having clause works with aggregate functions.having clause is used after group by clause.It acts like a post filter.
select sal,count(sal) as No_of_Employees from TBL_Employee
group by sal
having sum(sal)>10000