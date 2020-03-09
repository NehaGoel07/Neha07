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

from tbl_employees in TBL_Employees
group tbl_employees by tbl_employees.Emp_salary into salary
select salary.Key



