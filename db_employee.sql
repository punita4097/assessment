
create table employee
(id int,name varchar(50),address varchar(50))

insert into employee values(1,'punita','fbd')

insert into employee values(2,'priya','noida')

insert into employee values(3,'pooja','delhi')

create procedure employeedetails @id int,@name varchar(50)

as


select * from employee

where id=@id and name=@name
go

exec employeedetails @id=1 ,@name='punita';


create table department(d_id int,d_name varchar(50))

insert into department values(1,'cs')

insert into department values(2,'IT')

select * from department

create table Customer(Account_number int,Customer_name varchar(50),Balance int)

insert into Customer values(1001,'Punita',10000)

insert into Customer values(1002,'Pooja',10000)

Update customer set Balance=Balance-100 where Account_number=1001
select * from employee


select * from customer

