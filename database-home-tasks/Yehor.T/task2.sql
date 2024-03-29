use HumanRescourceDepartment;

/*1*/
select entity.Id, entity.FullName, entity.Residence, entity.Email
from Employee entity
where Age >= 50;

/*2*/
select *
from Employee
where Age >= 50 and Age <= 55;

/*3*/
select entity.Id, entity.FullName
from Employee entity
where len(entity.FullName) = 21;

/*4*/
declare @letter char(1) = 'L';
declare @mask1 char(2) = @letter + '%';
declare @mask2 char(3) = '%'+ @letter + '%';

select entity.Id, entity.FullName, entity.Residence, entity.Email
from Employee entity
where entity.FullName like @mask1 and (entity.Residence like @mask2 or entity.Email like @mask2);

