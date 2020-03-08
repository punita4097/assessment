<Query Kind="Expression">
  <Connection>
    <ID>a81c525c-26d7-4951-ae16-891d6c3e26f0</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>linq_database</Database>
  </Connection>
</Query>

//Ques1. Write LINQ syntax and define each term of the syntax

//There is two types of query syntax:1.query syntax,2.method syntax

//1.Query syntax

//here a is range variable

//addresses is the table in the database
//where and select is the standard query operators

from a in Addresses
where a.Id>3 
select new
{
	a.Id,
	a.City
}
//2.Method syntax

//here where is extension method

//after the where the part which is encloses in the parenthesis is lamba expression
Addresses.Where(s=>s.Id>3)