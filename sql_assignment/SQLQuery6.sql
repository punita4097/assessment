
--6. Find the data from a table between two dates.

create table session(s_id int primary key,s_name varchar(50),from_date date,to_date date)

insert into session values(1,'common', '2/3/2020','2/15/2020')

insert into session values(2,'basic of .net', '2/21/2020','2/25/2020')
insert into session values(3,'web development', '2/26/2020','2/28/2020')
 
 select *  from session 

 --display the data
 SELECT  * FROM    session
WHERE   From_date >= '2/3/2020' AND To_date   <= '2/25/2020'