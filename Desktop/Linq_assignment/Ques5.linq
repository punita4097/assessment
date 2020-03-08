<Query Kind="Statements">
  <Connection>
    <ID>a81c525c-26d7-4951-ae16-891d6c3e26f0</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>linq_database</Database>
  </Connection>
</Query>

// Ques5. Write LINQ to get records using left join from two tables.

var Result = from o in Addresses join od in Persons on o.Id equals od.Id
						
							 into eGroup
                    from od in eGroup.DefaultIfEmpty()
                           select new  { o.City,od.Name};
						  
						  Result.Dump();						 