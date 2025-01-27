create database quanlyquancaphe
go
use quanlyquancaphe
go

create table tablefood
(
id int identity primary key,
 ten Nvarchar (100) not null default N'chua dat ten',
 status Nvarchar(100) not null default N'trong'
 )
go

 create table account
 (
 username Nvarchar(100) primary key,
 displayname Nvarchar(100) not null default N'NguyenDaiLoc',
 password Nvarchar(1000) not null default 0,
 type int not null default 0 --1 admin, 0 staff
  )
  go

create table foodcaterogy
( 
id int identity primary key,
 ten Nvarchar (100) not null default N'chua dat ten',
 )
go

create table food
(
id int identity primary key,
 ten Nvarchar (100) not null default N'chua dat ten',
 idcategory int not null,
 price float not null default 0,
 foreign key ( idcategory) references foodcaterogy(id) 
 )
 go

 create table bill
 (
 id int identity primary key,
 datecheckin date not null default getdate(),
 datecheckout date,
 idtable int not null,
 status int not null default 0

 foreign key ( idtable) references  tablefood(id) 
 )
 go

 create table billinfo
 (
 id int identity primary key,
 idbill int not null, 
 idfood int not null,
 count int not null default 0
 foreign key (idbill) references  bill(id),
 foreign key ( idfood) references  food(id) 
 )
 go


 declare @i int = 0
 while @i <= 10
 begin
     insert dbo.tablefood (ten)values (N'Bàn '+ cast (@i as nvarchar(100)))
	 set @i = @i + 1
 end	
 select * from dbo.tablefood

 go
  update dbo.tablefood set status = N'có người' where id=9
 create proc usp_gettablelist
 as select * from dbo.tablefood
 go



 insert dbo.foodcaterogy
 (ten)
 values (N'hải sản')--ten nvachar(100) 
insert dbo.foodcaterogy
 (ten)
 values (N'Nông sản')
 insert dbo.foodcaterogy
 (ten)
 values (N'Lâm sản')
 insert dbo.foodcaterogy
 (ten)
 values (N'tùm lum sản')
 insert dbo.foodcaterogy
 (ten)
 values (N'nước uống')
 --thêm thức ăn 
 insert dbo.food
 (ten, idcategory, price)
 values (N'Cá ngừ nướng nguyên con', 1, 1000000)
 insert dbo.food
 (ten, idcategory, price)
 values (N'Cá Heo nướng nguyên con', 1, 1000000)
 insert dbo.food
 (ten, idcategory, price)
 values (N'Cá Sấu nướng nguyên con', 1, 1000000)
 insert dbo.food
 (ten, idcategory, price)
 values (N'Cá Rồng nướng nguyên con', 1, 1000000)
 insert dbo.food
 (ten, idcategory, price)
 values (N'Sting', 1, 12000)
 insert dbo.food
 (ten, idcategory, price)
 values (N'7 Up', 1, 12000)
 insert dbo.food
 (ten, idcategory, price)
 values (N'Cọp nướng nguyên con', 1, 1000000)
 --thêm bill
 insert dbo.bill
		 ( datecheckin,
		 datecheckout,
		 idtable,
		 status
		 )
 values
		 (GETDATE(),
			 null, 
			 3,
			 0
			 )
			 insert dbo.bill
		 ( datecheckin,
		 datecheckout,
		 idtable,
		 status
		 )
 values
		 (GETDATE(),
			 null, 
			 4,
			 0
			 )
			 insert dbo.bill
		 ( datecheckin,
		 datecheckout,
		 idtable,
		 status
		 )
 values
		 (GETDATE(),
			 null, 
			 5,
			 1
			 )
--thêm billinfo
insert dbo.billinfo
( idbill, idfood, count)
values (5, 
		1,
		2
		)
insert dbo.billinfo
( idbill, idfood, count)
values (5, 
		3,
		4
		)
		insert dbo.billinfo
( idbill, idfood, count)
values (5, 
		5,
		1
		)
		insert dbo.billinfo
( idbill, idfood, count)
values (6, 
		1,
		2
		)
		insert dbo.billinfo
( idbill, idfood, count)
values (6, 
		6,
		2
		)
		insert dbo.billinfo
( idbill, idfood, count)
values (7, 
		5,
		2
		)
		go
select * from dbo.billinfo
select * from dbo.bill
select * from dbo.tablefood



 exec dbo.usp_gettablelist
 select f.name, bi.count, f.price, f.price*bi.count as totalPrice from dbo.billinfo as bi, dbo.bill as b, dbo.food as f 
 where bi.idbill = b.id and bi.idfood = f.id and b.status =0 and b.idtable = 5
 select*from dbo.bill
 select*from dbo.food
 select*from dbo.billinfo	
 select*from dbo.foodcaterogy

 create proc usp_Insertbill
 @idtable int
 as
 begin
     insert dbo.bill
	         (datecheckin,
	          datecheckout,
	          idtable,
	          status
			 )
	 values  (GETDATE(); --datecheckin - date
	          null, --datecheckout - date
			  @idtable, --idtable - int
			  0 --status - int
			 )
 end
 go

 alter proc usp_Insertbillinfo
 @idbill int, @idfood int, @count int
 as
 begin
     declare @isExitsBillInfo int
	 declare @foodcount int = 1
	 select @isExitsBillInfo = id, @foodcount = b.count from dbo.billinfo as b where idbill = @idbill and idfood = @idfood
	 if (@isExitsBillInfo > 0)
	 begin
	     declare @newcount int = @foodcount + @count
		 if (@newcount > 0)
	         update dbo.billinfo set count = @foodcount + @count where idfood = @idfood
	     else
		     delete dbo.billinfo where idbill = @idbill and idfood = @idfood
	 end
	 else
	 begin
	 insert dbo.billinfo
	     (idbill. idfood, count)
     values(@idbill,--idbill-int
	        @idfood,--idfood-int
			@count,--count-int
	 )
	 end
 end
 go

