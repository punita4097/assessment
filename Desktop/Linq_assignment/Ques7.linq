<Query Kind="Statements">
  <Connection>
    <ID>a81c525c-26d7-4951-ae16-891d6c3e26f0</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>linq_database</Database>
  </Connection>
</Query>

//Ques7. Write LINQ to perform the Grouping operation.
//ToLookup execution is immediate and GroupBy execution is deferred by
//ToLookup execution can only use with method syntax

Addresses.GroupBy(c => c.City).Dump();

Addresses.ToLookup(c => c.City).Dump();