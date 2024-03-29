/*Task 1*/

/*1*/
create database HumanRescourceDepartment;

/*2*/
use HumanRescourceDepartment;

/*3*/
create table Employee(
	[Id] [int] identity(1,1) primary key not null,
	[FullName] [varchar](200) not null,
	[Residence] [varchar](100),
	[Email] [varchar](30) NULL,
	[Age] [int] not null,
	[ChildrensCount] [tinyint] not null,
	[Gender] [char](1) not null,
	[AcceptDate] [date] not null,
	)

/*4*/
insert into Employee (FullName, Residence, Email, Age, ChildrensCount, Gender, AcceptDate)
values
('Brendin Murray', 'China', 'bmurray0@ocn.ne.jp', 28, 3, 'M', '2017-02-27'),
('Anderea Bellringer', 'France', 'abellringer1@wired.com', 40, 5, 'F', '2007-09-10'),
('Shellysheldon Speller', 'Greece', 'sspeller2@arstechnica.com', 37, 1, 'F', '2015-07-25'),
('Isadora Serrels', 'Brazil', 'iserrels3@boston.com', 59, 4, 'M', '2018-05-21'),
('Mikol Blockley', 'South Africa', 'mblockley4@sina.com.cn', 34, 1, 'F', '2011-08-23'),
('Leslie Riceards', 'Greece', 'lriceards5@alibaba.com', 47, 4, 'F', '2005-10-05'),
('Christiana Valasek', 'Philippines', 'cvalasek6@cdc.gov', 59, 2, 'M', '2002-03-31'),
('Sinclare Flett', 'Canada', 'sflett7@pbs.org', 55, 4, 'F', '1995-04-15'),
('Sada Nell', 'Japan', 'snell8@cnet.com', 29, 0, 'F', '2002-11-11'),
('Lethia Snugg', 'Indonesia', 'lsnugg9@mlb.com', 43, 5, 'M', '2006-11-20'),
('Grace Firebrace', 'Argentina', 'gfirebracea@cons.com', 65, 3, 'M', '2014-03-29'),
('Jaclin Tighe', 'Iran', 'jtigheb@hao123.com', 53, 1, 'F', '2004-02-10'),
('Isabelita Redmile', 'Kuwait', 'iredmilec@globo.com', 40, 4, 'F', '2020-03-30'),
('Pavlov Fronzek', 'Vietnam', 'pfronzekd@qq.com', 49, 1, 'M', '2007-04-01'),
('Marsiella Zanussii', 'Australia', 'mzanussiie@webmd.com', 31, 5, 'M', '2021-02-01'),
('Avigdor McGinny', 'Philippines', 'amcginnyf@yale.edu', 31, 5, 'M', '1999-03-11'),
('Tripp Broomhead', 'China', 'tbroomheadg@java.com', 31, 1, 'M', '1990-11-13'),
('Rodina Daymont', 'Russia', 'rdaymonth@noaa.gov', 66, 5, 'F', '2016-05-08'),
('Drugi Suller', 'South Africa', 'dsulleri@phoca.cz', 34, 3, 'F', '2010-02-17'),
('Marthe Alasdair', 'Cambodia', 'malasdairj@tamu.edu', 30, 2, 'M', '1993-03-13');

/*drop*/​
drop table Employee;
