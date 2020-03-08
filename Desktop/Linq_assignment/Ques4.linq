<Query Kind="Statements">
  <Connection>
    <ID>a81c525c-26d7-4951-ae16-891d6c3e26f0</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>linq_database</Database>
  </Connection>
</Query>

//Ques4. Write LINQ to get records using inner join and display columns from both tables.

//here address and the person is the second table.
//we have join them on the bases of their common id.

var Result = from o in Persons join od in Addresses on o.Id equals od.Id
                           select new  { o.Name,od.City};
						  
						  Result.Dump();