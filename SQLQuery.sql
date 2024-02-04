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
ALTER TABLE City
ADD Abbreviation VARCHAR(10) NOT NULL;


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
ALTER TABLE Trip
ADD Capacity int check (Capacity > 0);


CREATE TABLE Reservation(
	ID int primary key identity(1,1),
	Id_client int foreign key references Client(ID),
	Id_trip int foreign key references Trip(ID),
	Number_pple int check(number_pple >= 1),
	Date_reservation datetime,
	[Status] bit default 0
)
--alter table Reservation
--add [Status] bit default 0

-- Insert three records into the Client table
	INSERT INTO Client (Surname, [Name], Email, Telephone)
	VALUES
		('Doe', 'John', 'john.doe@example.com', '+420 777 688 866'),
		('Smith', 'Jane', 'jane.smith@example.com', '+420 774 890 743'),
		('Johnson', 'Bob', 'bob.johnson@example.com', NULL);

-- Insert records into the Transport table
	INSERT INTO Transport([Type]) VALUES ('Airplane'), ('Bus'), ('Train')
	INSERT INTO Transport([Type]) VALUES ('Private Transport')

-- Insert three records into the Reservation table
	INSERT INTO Reservation(Id_client, Id_trip, Number_pple, Date_reservation)
	VALUES (1, 2, 4, SYSDATETIME())


-- Insert three records into the Hotel table
	INSERT INTO Hotel ([Name], Street, Number1, Number2, Postcode, Quality)
	VALUES
		('Grand Hotel', 'Main Street', 123, NULL, '12345', 4),
		('City View Inn', 'Downtown Avenue', 456, 789, '67890', 3),
		('Cozy Retreat', 'Quiet Lane', 789, NULL, '98765', 5);

-- Insert three records into the City table
	INSERT INTO City (Name, Abbreviation)
	VALUES
		('New York', 'NY'),
		('London', 'LDN'),
		('Paris', 'PRS');

-- Insert three records into the Trip table
	INSERT INTO Trip (Id_transport, Id_hotel, Id_departCity, Id_destinationCity, Date_depart, Date_return, Price)
	VALUES
		(4, 4, 1, 2, '2024-02-01', '2024-02-10', 1500.00),
		(5, 3, 2, 1, '2024-03-15', '2024-03-25', 2000.00),
		(3, 2, 3, 3, '2024-04-20', '2024-04-30', 1800.00);

-- CREATE VIEWS
	create view TripView as
	select 
	trip.ID,
	DepartureCity.Name AS Departure,
	DestinationCity.Name AS Destination, transport.[Type] AS Transport, date_depart as 'From', date_return 'To', hotel.name AS Hotel,
	hotel.quality AS Number_Star, trip.price AS Price, trip.capacity AS Capacity from trip
	inner join transport on trip.id_transport = transport.id
	inner join hotel on trip.id_hotel = hotel.id
	INNER JOIN City AS DepartureCity ON Trip.Id_departCity = DepartureCity.ID
	INNER JOIN City AS DestinationCity ON Trip.Id_destinationCity = DestinationCity.ID;


	create view ReservationView as
	select 
	Reservation.ID,
	CONCAT(client.Name, ' ', client.Surname) as Client, trip.ID as 'Trip Number', departurecity.Name as 'Departure', destinationcity.Name as 'Destination', Reservation.Number_pple as 'Pax', Reservation.Date_reservation as 'Reservation Date', (Reservation.Number_pple * Trip.Price) as 'Total (CZK)',Reservation.Status
	from Reservation
	inner join client on reservation.id_client = client.ID
	inner join trip on reservation.id_trip = trip.ID
	inner join city as departurecity on trip.Id_departCity = departurecity.ID
	inner join city as destinationcity on trip.Id_destinationCity = destinationcity.ID

	-- drop view ReservationView;

select Reservation.Id_trip, sum(Number_pple) as 'reserved', (trip.capacity - sum(Number_pple)), departurecity.Name as 'Departure', destinationcity.Name as 'Destination' from Reservation 
inner join trip on Reservation.Id_trip = trip.ID 
inner join city as departurecity on trip.Id_departCity = departurecity.ID 
inner join city as destinationcity on trip.Id_destinationCity = destinationcity.ID 
group by Reservation.Id_trip, departurecity.Name, destinationcity.Name, trip.capacity 
order by sum(Number_pple)

delete from Trip where id = 1

select 
	trip.ID,
	DepartureCity.Name AS Departure,
	DestinationCity.Name AS Destination, transport.[Type] AS Transport, date_depart as 'From', date_return 'To', hotel.name AS Hotel,
	hotel.quality AS Number_Star, trip.price AS Price, trip.capacity AS Capacity from trip
	inner join transport on trip.id_transport = transport.id
	inner join hotel on trip.id_hotel = hotel.id
	INNER JOIN City AS DepartureCity ON Trip.Id_departCity = DepartureCity.ID
	INNER JOIN City AS DestinationCity ON Trip.Id_destinationCity = DestinationCity.ID;


	select 
	Reservation.ID,
	CONCAT(client.Name, ' ', client.Surname) as Client, 
	departurecity.Name as 'Departure', 
	destinationcity.Name as 'Destination', 
	(Reservation.Number_pple * Trip.Price) as 'Total (CZK)',
	Reservation.Status
	from Reservation
	inner join client on reservation.id_client = client.ID
	inner join trip on reservation.id_trip = trip.ID
	inner join city as departurecity on trip.Id_departCity = departurecity.ID
	inner join city as destinationcity on trip.Id_destinationCity = destinationcity.ID

select * from Reservation