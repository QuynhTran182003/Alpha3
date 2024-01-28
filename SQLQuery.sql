CREATE DATABASE Cestovni_Agentura;
USE Cestovni_Agentura;

CREATE TABLE Client(
	ID int primary key identity(1,1),
	Surname varchar(64) NOT NULL,
	[Name] varchar(64) NOT NULL,
	Email varchar(64) NOT NULL check (Email LIKE '%@%.%'),
	Telephone varchar(20)
)

CREATE TABLE Transport(
	ID int primary key identity(1,1),
	[Type] varchar(20) check ([Type] in ('Airplane', 'Bus', 'Train', 'Private Transport'))
)

CREATE TABLE Hotel(
	ID int primary key identity(1,1),
	[Name] varchar(100) NOT NULL,
	Street varchar(64) NOT NULL,
	Number1 int NOT NULL,
	Number2 int,
	Postcode varchar(8) NOT NULL,
	Quality int
)

CREATE TABLE City(
	ID int primary key identity(1,1),
	[Name] varchar(100) NOT NULL,
)