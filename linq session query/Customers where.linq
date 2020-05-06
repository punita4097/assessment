<Query Kind="Statements">
  <Connection>
    <ID>01709185-5faa-47cc-aa93-8b1bb4b2997d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>ado_assignment</Database>
  </Connection>
</Query>

/*from c in Customers
where c.Account_number==1001 
select new
{
	c.Account_number,
	c.Customer_name,
	c.Balance
}
*/
var filteredResult = from c in Customers
where c.Account_number==1001 
select new
{
	c.Account_number,
	c.Customer_name,
	c.Balance
}
;