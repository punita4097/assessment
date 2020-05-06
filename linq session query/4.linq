<Query Kind="Expression">
  <Connection>
    <ID>01709185-5faa-47cc-aa93-8b1bb4b2997d</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-9NTF17Q</Server>
    <Database>ado_assignment</Database>
  </Connection>
</Query>

Customers.OrderByDescending(t=>t.Customer_name).ThenBy(t=>t.Account_number)