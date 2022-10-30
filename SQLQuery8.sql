create  DATABASE TransportManagent

use TransportManagement
go

create table Admin(
AdminID int identity(1,1),
UserName nchar(80)NOT NULL,
Password nchar(80)NOT NULL,
);

drop table Admin
create table Admin(
AdminID int identity(1,1) primary key,
UserName nchar(80)NOT NULL,
Password nchar(80)NOT NULL,
);

drop table Admin_Info

create table Vehicle(
VehicleID int identity(1,1)primary key,
Vehicle_No int ,
Capacity int NOT NUll,
Available_seats int NOT NULL,
Operable varchar(20) NOT NULL
);
select * from Vehicle

create table Route(
RoutetID int identity(1,1)primary key,
RouteNO int,
Stop_1 varchar(40) NOT NULL,
Stop_2 varchar(40) NOT NULL,
Vehicle_No int FOREIGN KEY REFERENCES Vehicle(VehicleID)
);

drop table Route

create table Employee(
Employee_ID int primary key identity(1,1),
Employee_Name varchar(30) NOT NULL,
Age int not null,
Location varchar(40) NOT NULL,
Phone nchar(30) NOT NULL,
Vehicle_ID int FOREIGN KEY REFERENCES Vehicle(VehicleID)
);

drop table Employee_Info

select *from Employee

insert into Employee_Info
values('Chandra Sekar', 22,'Nanganallur Road',7388737738,91);

select * from flight

use TransportManagement
go

select *from 