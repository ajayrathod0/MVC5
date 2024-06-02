create database EmployeeAssignmentDB
go
use EmployeeAssignmentDB
go
create table State
(
StateId int primary key identity,
StateName varchar(100) not null
)
go
create table District
(
DistrictId int primary key identity,
DistrictName varchar(100) not null,
StateId int not null foreign key references State(StateId) on delete cascade
)
go
create table City
(
CityId int primary key identity,
CityName varchar(100) not null,
Description varchar(500),
DistrictId int not null foreign key references District(DistrictId) on delete cascade
)
go
create table Employee
(
EmployeeId int primary key identity,
Name varchar(50) not null,
Designation varchar(50) not null,
Salary decimal not null,
Address varchar(500) not null,
Mobile char(10) not null,
CreatedDate datetime2,
ModifiedDate datetime2,
DeletedDate datetime2,
CityId int foreign key references City(CityId) on delete cascade
)
go

insert into State values ('Maharashtra'), ('Gujrat')
go
insert into District values ('Pune', 1), ('Thane', 1), ('Surat', 2), ('Ahmadabad', 2)
go
insert into City values ('Katraj', 'katraj city', 1), ('Narhe', 'narhe goan', 1), 
('Kalyan','kalyan city', 2)

go

select * from State
select * from District
select * from City
select * from Employee
