<Query Kind="Expression">
  <Connection>
    <ID>a81c525c-26d7-4951-ae16-891d6c3e26f0</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>linq_database</Database>
  </Connection>
</Query>

//Ques6. Write LINQ to perform aggregate function Count, Max, Min, Average on the table.

//count the number of employee
Persons.Count()

//find the max salary in the persons table

Persons.Max(s=>s.Salary)

//Find the minimum salary in the persons table


Persons.Min(s=>s.Salary)

//Find the average of the salary

Persons.Average(s=>s.Salary)
