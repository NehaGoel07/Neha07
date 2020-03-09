<Query Kind="Statements">
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

var count=(from tbl in TBL_Employees
select tbl.Emp_name).Count();
Console.WriteLine("No of Employees: "+count);

var max_sal=(from tbl in TBL_Employees
select tbl.Emp_salary).Max();
Console.WriteLine("Maximum Salary: "+max_sal);

var min_sal=(from tbl in TBL_Employees
select tbl.Emp_salary).Min();
Console.WriteLine("Minimum Salary: "+min_sal);

var avg_sal=(from tbl in TBL_Employees
select tbl.Emp_salary).Average();
Console.WriteLine("Average Salary: "+avg_sal);