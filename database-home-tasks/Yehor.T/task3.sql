use HumanRescourceDepartment;

/*1*/
create table Residence(
	[Id] [int] identity(1,1),
	[CountryName] varchar(30) unique not null,
	primary key (Id));

/*2*/
alter table Employee
add [ResidenceId] int;

/*3*/
alter table Employee
add CONSTRAINT  FK_Employee_Residence foreign key ([ResidenceId]) references Residence(Id)
on delete set null;

/*4*/
insert into Residence
([CountryName])
values
('China'),
('France'),
('Greece'),
('Brazil'),
('South Africa');

/*5 (19 times)*/
update Employee
set [ResidenceId] = 1
where [Id] = 1;

/* Set null to some fields in [Employee] */
update Employee
set [ResidenceId] = NULL
where [Id] = 8;

update Employee
set [ResidenceId] = NULL
where [Id] = 18;

update Employee
set [ResidenceId] = NULL
where [Id] = 3;

/*Select*/
/*6*/
select * from Employee
where Employee.ResidenceId is null

/*7*/
select * from Employee
join Residence on Employee.ResidenceId = Residence.Id

/*7.1*/
select Employee.FullName, Employee.Email, Employee.Age, 
Employee.ChildrensCount, Employee.Gender, Employee.AcceptDate, 
Residence.CountryName 
as Residence from Employee
join Residence on Employee.ResidenceId = Residence.Id

/* drop */
alter table Employee
drop constraint FK_Employee_Residence;

alter table Employee
drop column ResidenceId;


