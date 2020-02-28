--9. Difference b/w having clause and where clause provide examples.

-- having clause is used with aggregate function.It is used with group by clause
-- where clause cannot be used with aggregate function.

create table condition(id int,subject varchar(50),marks int)

insert into condition values(1,'english',96)


insert into condition values(2,'maths',100)
insert into condition values(3,'hindi',92)
insert into condition values(4,'science',98)
insert into condition values(5,'social science',90)

insert into condition values(1,'hindi',89)
insert into condition values(2,'english',79)
insert into condition values(3,'english',86)
insert into condition values(4,'english',76)
insert into condition values(5,'english',66)

select * from condition

--query using having

select sum(marks) from condition  group by id having id =2

--query using where
select subject from condition where id=3

