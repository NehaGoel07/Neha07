<Query Kind="Expression">
  <Connection>
    <ID>a087e027-aeff-455a-829f-d0d6ee8bddb9</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-JJOPP64\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAARuF1VkIEIU+l0VZW+uOJjgAAAAACAAAAAAAQZgAAAAEAACAAAACR4MGoscC7whioLDmx5iyzVD1tBAkPWqHbdJaXuKUVgwAAAAAOgAAAAAIAACAAAADovxRcUdoL5ZS/CMXDnm/qn5RuqDsclwivJ0DLZrylehAAAAC+1zQ+iBsJonwnjEkt/y06QAAAANy4ng8wwcmV71w32b8woP3EqfG+gtdPjVaBpII7jxah0/l65wVV6krIK8OF5YfM++WebcJ0xZrHPvcs9og48y0=</Password>
    <Database>BootCamp2020</Database>
  </Connection>
</Query>

from t1 in TBL_Employees 
join t2 in Employees 
on t1.Emp_id equals t2.Emp_id
select new {t1.Emp_id,t1.Emp_name,t1.Emp_dob,t1.Emp_salary,t1.Manager_id,t1.IsTrainer,t2}