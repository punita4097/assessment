/*
1. Create a table (datatype should be appropriate for each column).Insert data into table,Update one table data using join with other table (you can create another table   which takes the reference from the first table). Table structure should be like.
    Id column should be primary key and identity,
    EmpName,
    Mobile number should have 10 digits apply constraint.
    DateOfBirth,Address,salary,
    ZIP code should be 6 digits long,
    IsActive
   CreatedDate,
   ModifiedDate.
 */

 create table Employee
(emp_id int identity(4000,1) primary key,
emp_name varchar(255),
mobile varchar(10) constraint c check( mobile like '[6-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
dob date,
address varchar(255),
zipcode varchar(6),
salary int,
isactive bit,
created_date datetime2,
modified_date datetime2
)


select * from Employee

insert into Employee (emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date)       
values('Punita','6876543210','4/05/1997','Faridabad','121003',1,GETDATE(),GETDATE())

insert into Employee (emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date)  
values('Neha','8876543210','3/08/1997','sarai','121003',1,GETDATE(),GETDATE())

insert into Employee (emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date)  
 values('Arpit','9876543210','7/08/1997','delhi','131003',1,GETDATE(),GETDATE())


insert into Employee(emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date)
values('Shagun','7876543210','6/09/1997','Badarpur','141003',1,GETDATE(),GETDATE())


insert into Employee(emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date)
values('Sonal','6876543210','5/05/1997','dwarka','151003',1,GETDATE(),GETDATE())

insert into Employee(emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date) 
values('Abhishek','6976543210','2/07/1997','patel nagar','161003',1,GETDATE(),GETDATE())


insert into Employee(emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date) 
values('Latika','8276543210','1/03/1997','karol bagh','171003',1,GETDATE(),GETDATE())

insert into Employee (emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date)
values('Vishesh','7876543219','4/02/1997','rajiv chowk','181003',1,GETDATE(),GETDATE())

insert into Employee (emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date)
values('Azeem','6876543217','6/06/1997','dilshad garden','191003',1,GETDATE(),GETDATE())

insert into Employee (emp_name,mobile,dob,address,zipcode,isactive,created_date,modified_date)
values('Vijay','6876543106','4/11/1997','janakpuri','171002',1,GETDATE(),GETDATE())

select * from employee


--drop table record

--record table is the table in which we enter the salary details of the employee
create table record
(emp_id int,month varchar(20),salary int, foreign key(emp_id) references Employee(emp_id))

select * from record

--truncate  table record

/*data entry in the record table*/

insert into record values(4000,'january',9000)
insert into record values(4002,'february',8000)
insert into record values(4000,'march',7000)
insert into record values(4002,'april',6000)
insert into record values(4000,'may',5000)
insert into record values(4002,'june',4000)
insert into record values(4001,'january',3000)
insert into record values(4003,'february',2000)
insert into record values(4001,'march',9000)
insert into record values(4003,'april',8000)
insert into record values(4001,'may',7000)
insert into record values(4003,'june',6000)
insert into record values(4005,'jan',5000)
insert into record values(4004,'january',4000)
insert into record values(4005,'february',3000)
insert into record values(4004,'march',2000)
insert into record values(4005,'april',1000)
insert into record values(4004,'may',9000)
insert into record values(4006,'january',8000)
insert into record values(4007,'february',7000)
insert into record values(4006,'march',6000)
insert into record values(4007,'april',5000)
insert into record values(4006,'may',5500)
insert into record values(4007,'june',2000)
insert into record values(4008,'january',1000)
insert into record values(4009,'february',2000)
insert into record values(4008,'march',3000)
insert into record values(4009,'april',4000)
insert into record values(4008,'may',5500)
insert into record values(4009,'june',2000)
insert into record values(4000,'july',1000)
insert into record values(4001,'july',2000)
insert into record values(4002,'july',3000)
insert into record values(4003,'july',4000)
insert into record values(4004,'july',5500)
insert into record values(4005,'july',2000)
insert into record values(4006,'july',2000)
insert into record values(4007,'july',2000)
insert into record values(4008,'july',2000)
insert into record values(4009,'july',2000)
insert into record values(4009,'july',2000)


select * from record

select * from record order by emp_id

--update value into employee table from record table

update employee
set employee.salary=record.salary

from employee inner join (select emp_id,sum(salary)as salary from record group by emp_id)

 record on employee.emp_id=record.emp_id

 --see the employee table
 select * from employee
