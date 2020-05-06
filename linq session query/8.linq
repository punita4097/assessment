<Query Kind="Statements">
  <Connection>
    <ID>01709185-5faa-47cc-aa93-8b1bb4b2997d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>Bootcamp2020</Database>
  </Connection>
</Query>

bool p = Employees.Any(s=>s.Emp_id>4000&&s.Emp_id<4004);

Console.WriteLine(p);

Employees

Employees

var sal=from s in Employees
select s.E_salary

var res = Employees.Min(a => a.E_salary); 
        Console.WriteLine("Average salary of the Employees: {0}", res);