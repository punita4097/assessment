<Query Kind="Statements" />

string[] delhiResidents = { "Ramesh", "Kapil", "Vikas", "Amit" };
string[] kolkataResidents = { "Kapil", "Manmohan", "Deepak", "Amit" };
 
var allResidents = delhiResidents.Union(kolkataResidents);
 
foreach (var item in allResidents)
{
    Console.WriteLine(item);
}