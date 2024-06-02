create Database B22MVCAuthenticationDB
go
use B22MVCAuthenticationDB
go

create table Users
(
UserId int Primary key identity,
Email Varchar(500),
PassWord Varchar(30),
IsActive bit,
CreateDate datetime2
)

go

create table Roles(
RoleId int Primary key identity,
RoleName Varchar(50)
)
 insert into Roles values('Admin'),('Seller'),('User')

 go

 create table UserRoles(
 UserRoleId int Primary key identity,
 UserId int foreign key references Users(UserId),
 RoleId int foreign key references Roles(RoleId)
 )

 go

 create table Product(
 ProductId int primary key identity,
 Name Varchar(500),
 Price int,
 AddedDate datetime2
 )
 go

 select * from Product
 select * from Roles
 select * from UserRoles
 select * from Users
