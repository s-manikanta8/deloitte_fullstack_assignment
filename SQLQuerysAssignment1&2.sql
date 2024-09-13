Create table Users (UserId int , UserName varchar(49), Password varchar(40), ContactNumber varchar(20), City varchar(29))
select * from users
insert into users values(123,'mani','mani@1','392002910','nuzvid')
create table Products (ProductId int Primary Key,
						PName varchar(28) Not Null, 
						QuantityInStock int Not Null check (QuantityInStock >0),
						UnitPrice int Not null, check (UnitPrice >0),
						Category  varchar(45) Not null)

select * from Products
insert into users values(133,'mouni','mouni@1','39224131','nuzvid')
insert into users values(13,'ramya','ramya@1','3478292','hyderabad')
insert into Products values(123,'laptop',24,50000,'Electronics')
insert into Products values(12,'Mobile',10,25000,'Electronics')
insert into Products values(121,'watch',13,2500,'wearables')
insert into Products values(125,'table',10,25000,'Furniture')
Drop table Products

Create table Cart(Id int Primary Key,  
						CartId  int NOT NULL, 
						ProductId  int, 
						Quantity int  Not Null check (Quantity>0),constraint fk_cart_Products Foreign Key (ProductId) References Products(ProductId))

select *  from cart
insert into cart values(1276,234,123,25)
insert into cart values(1272,2343,121,25)
insert into cart values(12,2342,125,25)

select * from Products 
where category='Electronics'

select * from Products
where QuantityInStock = 0

select * from Products
where UnitPrice>1000 and UnitPrice<10000

select * from Products
order by ProductId 

select * from cart
order by cartid

select * from cart
join Products
on cart.ProductId=Products.ProductId


Select * from Users

select * from Users order by ContactNumber

select * from Users  Order by Userid



select  C.CartId,p.PName,c.Quantity,p.UnitPrice 
from Cart c
join Products p
on c.ProductId = p.ProductId

select  C.CartId,p.PName,c.Quantity,p.UnitPrice 
from Cart c
inner join Products p
on c.ProductId = p.ProductId

select  C.CartId,p.PName,c.Quantity,p.UnitPrice 
from Cart c
right outer join Products p
on c.ProductId = p.ProductId

select  C.CartId,p.PName,c.Quantity,p.UnitPrice 
from Cart c
left outer join Products p
on c.ProductId = p.ProductId

select  C.CartId,p.PName,c.Quantity,p.UnitPrice 
from Cart c
full outer join Products p
on c.ProductId = p.ProductId

Create table Student (StudentId int Primary key,  StudentName varchar(45),  CourseName varchar(45),  City varchar(23))

insert into Student values(122,'mani','angular','Nuzvid')
insert into Student values(123,'veera','javascript','Prakasam')
insert into Student values(124,'varun','c#','Hyderabad')
insert into Student values(125,'viswa','angular','Hyderabad')
insert into Student values(126,'Kalyan','asp.net','Vijayawada')
insert into Student values(127,'hari','c#','vijayawada')

select count(*) as Noofstudents from Student where CourseName='angular'

select city,count(*) as Noofstudents from Student Group by City

select CourseName,count(*) as Noofstudents from Student Group by CourseName

select CourseName,city,count(*) as Noofstudents from Student Group by CourseName,City



Select * from Products where ProductId in (select ProductId from cart )

Select * from Cart where ProductId in (select ProductId from Products where UnitPrice>5000)

select * from Products  where ProductId in (Select ProductId from Cart ) and UnitPrice>5000

