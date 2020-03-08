<Query Kind="Expression">
  <Connection>
    <ID>a81c525c-26d7-4951-ae16-891d6c3e26f0</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>linq_database</Database>
  </Connection>
</Query>

//Ques10. Write LINQ to find 3rd highest Salary from the table

Persons.OrderByDescending (p => p.Salary).Take (3).Skip(2)