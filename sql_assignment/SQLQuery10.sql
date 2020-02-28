
--10.Difference between stored procedures and user defined functions. Explain with suitable examples.

--Basic Differences between Stored Procedure and Function in SQL Server
/*
The function must return a value but in Stored Procedure it is optional. Even a procedure can return zero or n values.

Functions can be called from Procedure whereas Procedures cannot be called from a Function.

function will not allow us to use try caatch block inside it wheares procedure does.

*/

create table customer(c_id int,name varchar(50),city varchar(30))

insert into customer values(1,'reena','delhi')

insert into customer values(2,'meena','fbd')

insert into customer values(3,'seena','gazipur')

insert into customer values(4,'teena','pune')
insert into customer values(5,'leena','pune')



select * from customer
--create procedure
CREATE PROCEDURE SelectAllCustomers (@city varchar(30))
AS
BEGIN
SELECT * FROM Customer WHERE city = @City

end
--execute procedure
EXEC SelectAllCustomers @City = "pune";


--create function

CREATE FUNCTION get_customer(@city varchar(30))  
RETURNS varchar(50)  
AS 
begin
RETURN  
	(SELECT  name FROM customer WHERE city=@city)
end
-- execute function
print dbo.get_customer('delhi')