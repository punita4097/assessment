--5. How to create and invoke user defined functions ?

--Types of User defined function
--Scalar Functions
--Table Valued Functions

--example for scalar function

create table Result(roll int primary key,student_name varchar(50),percentage int)

insert into result values(1,'punita',99)

insert into result values(2,'rajni',93)
insert into result values(3,'vipin',95)
insert into result values(4,'jitu',90)

select * from result


CREATE FUNCTION student_name(@percentage int )

RETURNS VARCHAR(50)

AS

BEGIN

RETURN (SELECT student_name from result where percentage=@percentage)

end

--execute the scalar function
print dbo.student_name(95)



-- tabular user defined function

CREATE FUNCTION GetAllStudents(@percentage INT)

RETURNS TABLE

AS

RETURN

SELECT *FROM result WHERE percentage>=@percentage

--execute the tabular user defined functions
SELECT * FROM GetAllStudents(95)
