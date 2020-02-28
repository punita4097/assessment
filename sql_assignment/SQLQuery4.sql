/*4. What are the benifits of using views also give an example ?

VIEWS-  A view is a virtual table in the database whose contents are defined by a query. 
		The view appears just like a real table, with a set of named columns and rows of data.

		Banefits of views are:
		1. Each user can be given permission to access the database only through a small set of views 
		that contain the specific data the user is authorized to see, 
		thus restricting the users access to stored data

		2. A view can draw data from several different tables and present it as a single table,
		turning multi-table queries into single-table queries against the view.
		*/

		create table Client(c_no int primary key,client_name varchar(30),Address varchar(255))

		insert into Client values(1,'punita','faridabad')

		insert into Client values(2,'priya','delhi')

		insert into Client values(3,'muskaan','karol bagh')

		insert into Client values(4,'khushi','dwarka')

		insert into Client values(5,'ankita','patel chowk')


		
	select * from Client

	create view [address_customer] as 
	select c_no,address 
	from Client 
	
	--display the view of the client table
	select * from [address_customer]
	




