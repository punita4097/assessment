--8. Create and invoke one stored procedure from another stored procedure.

create procedure first 
(  
@id int,  
@name varchar(50) 
)
as 
begin  
Declare @ques8 Table(id int, Name varchar(50))  
Insert into @ques8(id,Name)values(@ID,@name)  
select*from @ques8 
end


create procedure second
(
@s_id int,
@s_name varchar(50)
)
as
begin
exec first @id=@s_id,@name=@s_name  --call the first procedure
end

--execute the second procedure

Exec Second @s_id=1,@s_name='punita'  