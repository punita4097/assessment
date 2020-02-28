--3. How data can be copied from one table to another table ? 

create table copy_table
(emp_id int,month varchar(20),salary int)

select * from copy_table

insert into copy_table
 values(4001,'january',9000)
insert into copy_table
 values(4002,'february',8000)
insert into copy_table
 values(4003,'march',7000)
insert into copy_table
 values(4004,'april',6000)
insert into copy_table
 values(4005,'may',5000)
insert into copy_table
 values(4006,'june',4000)

 --see the first table where data is present
 select * from copy_table


 create table transfer_table
(emp_id int,month varchar(20),salary int)

select * from transfer_table

insert into transfer_table
select emp_id,month,salary from copy_table

--see the table where the table is present
select * from transfer_table




