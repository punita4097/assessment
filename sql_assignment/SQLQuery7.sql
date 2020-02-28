
--7. Give examples of self,Inner,left outer,right outer joins.

create table Employee1
(
e_id int identity(100,1) primary key,
e_name varchar(50),
e_dob datetime2(3),
e_salary money,
manager_id int
)
insert into Employee1 values('sachin','5-4-1997',50000,null)
insert into Employee1 values('ashish','5-3-1997',40000,100)
insert into Employee1 values('ritesh','5-4-1997',50000,100)
insert into Employee1 values('shakshi','5-4-1997',50000,100)
insert into Employee1 values('punita','11-6-1999',90000,103)
insert into Employee1 values('neha','2-8-1988',80000,103)
insert into Employee1 values('arpit','1-10-1985',100000,103)
insert into Employee1 values('shagun','12-8-1991',80000,100)

select * from employee1

--inner join,join
select e.e_name as employee1,m.e_name as manager
from Employee1 e
inner join Employee1 m
on e.manager_id=m.e_id

--left join
select e.e_name as employee1,m.e_name as manager
from Employee1 e
left join Employee1 m
on e.manager_id=m.e_id

--right outer join
select e.e_name as employee1,m.e_name as manager
from Employee1 e
right outer join Employee1 m
on e.manager_id=m.e_id

--self join
select e.e_name as employee1,m.e_name as manager
from Employee1 e, Employee1 m
where e.manager_id=m.e_id


