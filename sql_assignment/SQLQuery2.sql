--2. How to update column name of table ?

create table details(id int identity(100,1) primary key,name varchar(20))

select * from details

insert into details values('punita')

insert into details values('pooja')

insert into details values('preeti')

insert into details values('priya')

select * from details



execute sp_rename 'dbo.details.id','e_id','column'

select * from details




