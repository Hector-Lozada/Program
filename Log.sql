create database LLog
USE LLog;
go
create table  [Users](
Id UNIQUEIDENTIFIER primary key default NEWID(),
Username nvarchar (50) unique not null,
[Password] nvarchar(100) not null,
[Name] nvarchar(50) not null,
LastName nvarchar(50) not null,
Email nvarchar (100) unique not null
);
go
insert into [Users] values (NEWID(), 'ism17','19032004@','Hector','Lozada','ismaellozada85@gmail.com')
insert into [Users] values (NEWID(), 'joss','banguera','Josselyn','Banguera','joss@gmail.com')
go
select * from [Users]