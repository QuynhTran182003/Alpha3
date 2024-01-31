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

INSERT INTO Client (Surname, [Name], Email, Telephone)
VALUES
    ('Doe', 'John', 'john.doe@example.com', '+420 777 688 866'),
    ('Smith', 'Jane', 'jane.smith@example.com', '+420 774 890 743'),
    ('Johnson', 'Bob', 'bob.johnson@example.com', NULL);


CREATE TABLE Trip(
	ID int primary key identity(1,1),
	Id_transport int foreign key references Transport(ID),
	Id_hotel int foreign key references Hotel(ID),
	Id_departCity int foreign key references City(ID),
	Id_destinationCity int foreign key references City(ID),
	Date_depart date,
	Date_return date,
	Price decimal not null check (price > 0)
);

CREATE TABLE Reservation(
	ID int primary key identity(1,1),
	Id_client int foreign key references Client(ID),
	Id_trip int foreign key references Trip(ID),
	Number_pple int check(number_pple >= 1),
	Date_reservation datetime,
	[Status] bit
)

INSERT INTO Transport([Type]) VALUES ('Airplane'), ('Bus'), ('Train')
INSERT INTO Transport([Type]) VALUES ('Private Transport')
ALTER TABLE City
ADD Abbreviation VARCHAR(10) NOT NULL;

INSERT INTO Hotel ([Name], Street, Number1, Number2, Postcode, Quality)
VALUES
    ('Grand Hotel', 'Main Street', 123, NULL, '12345', 4),
    ('City View Inn', 'Downtown Avenue', 456, 789, '67890', 3),
    ('Cozy Retreat', 'Quiet Lane', 789, NULL, '98765', 5);

-- Insert three records into the City table with Name and Abbreviation
INSERT INTO City (Name, Abbreviation)
VALUES
    ('New York', 'NY'),
    ('London', 'LDN'),
    ('Paris', 'PRS');


	select * from City;
INSERT INTO Trip (Id_transport, Id_hotel, Id_departCity, Id_destinationCity, Date_depart, Date_return, Price)
VALUES
    (4, 4, 1, 2, '2024-02-01', '2024-02-10', 1500.00),
    (5, 3, 2, 1, '2024-03-15', '2024-03-25', 2000.00),
    (3, 2, 3, 3, '2024-04-20', '2024-04-30', 1800.00);

select 
DepartureCity.Name AS DepartureCityName,
DestinationCity.Name AS DestinationCityName, transport.[Type], date_depart, date_return, hotel.name,
hotel.quality, trip.price from trip
inner join transport on trip.id_transport = transport.id
inner join hotel on trip.id_hotel = hotel.id
INNER JOIN City AS DepartureCity ON Trip.Id_departCity = DepartureCity.ID
INNER JOIN City AS DestinationCity ON Trip.Id_destinationCity = DestinationCity.ID;