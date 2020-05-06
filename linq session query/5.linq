<Query Kind="Statements">
  <Connection>
    <ID>01709185-5faa-47cc-aa93-8b1bb4b2997d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>sql_assign</Database>
  </Connection>
</Query>


var groupedResult = Employees.GroupBy(s=>s.Salary);

foreach(var salaryGroup in groupedResult)
{
Console.WriteLine("salary Group:{0}",salaryGroup.key);

foreach(Employees s in salaryGroup)
Console.WriteLine("Employee name:{0}",s.Emp_name);
}


var innerJoin= from s in Employees join st in Records
on s.Emp_id equals st.Emp_id


select new
{
Salary=s.Salary

}