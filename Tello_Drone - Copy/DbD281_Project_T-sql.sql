--Creation of Database

--Batch START

CREATE DATABASE TheGemmiesAwrdS
ON PRIMARY
(
NAME = GemmiesData1,
FILENAME = 'C:\test\PrimaryDBfile.mdf',
SIZE = 2MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 4%
),
FILEGROUP SECONDARY
(
NAME = GemmiesData2Secondary,
FILENAME = 'C:\test\SecondaryDBfile.ndf',
SIZE = 10MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 2%
)
LOG ON
(
NAME = GemmiesLog,
FILENAME = 'C:\test\LogDBfile.ldf',
SIZE = 2MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 1%
)

USE TheGemmiesAwrdS
GO

--Creation of Tables
--Genre
CREATE TABLE Genre
(
GenreID INT PRIMARY KEY IDENTITY (1, 1),
Genre VARCHAR(25)
)

--AgeRestriction
CREATE TABLE AgeRestriction
(
AgeRestrictionID INT PRIMARY KEY IDENTITY (1, 1),
AgeRestriction VARCHAR(5) DEFAULT 'T' -- 'T' means that a movie was not yet checked to give a reliable age restriction
)

--Awards
CREATE TABLE Awards
(
AwardsID INT PRIMARY KEY IDENTITY (1, 1),
Awards VARCHAR(25)
)

--City
CREATE TABLE City
(
CityID INT PRIMARY KEY IDENTITY (1, 1),
CityName VARCHAR(35)
)

--Actor
CREATE TABLE Actor
(
ActorID INT PRIMARY KEY IDENTITY (1, 1),
Name VARCHAR(25),
Surname VARCHAR(25),
Phone VARCHAR(15) UNIQUE,
PostalAddress VARCHAR(25) UNIQUE,
PostalCode VARCHAR(25),
CityID INT FOREIGN KEY REFERENCES City(CityID),
Salary MONEY
)

--Director
CREATE TABLE Director
(
DirectorID INT PRIMARY KEY IDENTITY (1, 1),
Name VARCHAR(25),
Surname VARCHAR(25),
Phone VARCHAR(15) UNIQUE,
PostalAddress VARCHAR(25) UNIQUE,
PostalCode VARCHAR(25),
CityID INT FOREIGN KEY REFERENCES City(CityID)
)

--Movie
CREATE TABLE Movie
(
MovieID INT PRIMARY KEY IDENTITY (1, 1),
Title VARCHAR(25),
GenreID INT FOREIGN KEY REFERENCES Genre(GenreID),
AgeRestrictionID INT FOREIGN KEY REFERENCES AgeRestriction(AgeRestrictionID),
DirectorID INT FOREIGN KEY REFERENCES Director(DirectorID),
ReleaseDate DATETIME,
ProductionValue MONEY,
Profit MONEY
)

--MovieActor
CREATE TABLE MovieActor
(
MovieID INT FOREIGN KEY REFERENCES Movie(MovieID),
ActorID INT FOREIGN KEY REFERENCES Actor(ActorID)
)

--AwardsMovie
CREATE TABLE AwardsMovie
(
MovieID INT FOREIGN KEY REFERENCES Movie(MovieID),
AwardsID INT FOREIGN KEY REFERENCES Awards(AwardsID)
)

--Creating data and inserting it into Tables

INSERT INTO AgeRestriction
VALUES
('T'), -- 'T' means that a movie was not yet checked to give a reliable age restriction
('A'),
('7+'),
('10+'),
('PG'),
('13+'),
('18'),
('R')

INSERT INTO City
VALUES
('New-York'),
('Los Angelas'),
('Uitenhage'),
('Hollywood'),
('Brakpan'),
('Polokwane'),
('Port Elizabeth'),
('Zimbabwe')

INSERT INTO Awards
VALUES
('Best Female Actor'),
('Best Male Actor'),
('Most Heroic Role'),
('Most Selebrated Movie'),
('Most Expensive Movie'),
('Most Weight Gained for a Role'),
('Most Weight Lost for a Role')

INSERT INTO Genre
VALUES
('Horror'),
('Comedy'),
('Future'),
('Thriller'),
('Family'),
('Romance'),
('Rom-Com'),
('Food')

INSERT INTO Actor
VALUES
('Paul', 'Walker', 0986765434 , '19 Genadendaal', 6000 , 3 , 50000),
('John', 'Lennon', 8987587698 , '7 Kwagga st', 3455 , 7 , 12000),
('Piet', 'Pompies', 3423242313 , '99 Greenbushes', 6000 , 7 , 43532),
('Greg', 'Wimper', 3434567644 , '7 Floors up', 3435 , 1 , 53212),
('Ariel', 'Wash', 3546543254 , 'Ocean st', 777 , 2 , 100000),
('Jhon', 'Cena', 3245354453 , '14 Lewerkie', 6743 , 8 , -34422)

INSERT INTO Movie
VALUES
('The Ring', 2, 3, 4, 2021/03/08, 3425322, 234454),
('Cars', 6, 4, 1, 2019/11/02, 233445423, 254633223),
('Shrek', 6, 4, 1, 2000/01/20, 64536324, 435643234),
('Orphans', 2, 2, 1, 2020/03/08, 3425322, 234454),
('Batman', 7, 3, 3, 2010/02/11, 342533422, 324234454),
('Rambo', 2, 6, 7, 2027/03/02, 33425322, 554234454),
('Cyberpunk', 2, 3, 4, 2077/12/01, 34433425322, 2334454)

INSERT INTO Director
VALUES
('Jhon', 'Adams', 0986765434, '7 Kwagga st', 6000, 4),
('Rick', 'Roll', 3245354453, '7 Floors up', 3455, 7),
('Jack', 'Daniels', 3434567644, '99 Greenbushes', 6000, 2),
('Steve', 'Hofmeier', 8987587698, 'Ocean st', 3435, 2),
('Austin', 'Powers', 3546543254, '14 Lewerkie', 6743, 1)

--Batch END

--Creation of Queries and Views

--Selecting all data in Movie table ;)

SELECT * FROM Movie

--Stored procedure

USE TheGemmiesAwrdS
GO

CREATE PROCEDURE spNewAward @Award VARCHAR(25)
AS
BEGIN
INSERT
INTO Awards
Awards.Awards
VALUES 
(@Award)
END

EXECUTE spNewAward @Award = 'Most viewed'

SELECT * FROM Awards

--Views

GO
CREATE VIEW MovieGenre AS
SELECT Movie.Title, Movie.GenreID, Movie.AgeRestrictionID, Genre.Genre
FROM Movie
INNER JOIN Genre
ON Movie.GenreID = Genre.GenreID

GO
SELECT * FROM MovieGenre




