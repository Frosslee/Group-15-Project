--Creation of Database
--Batch START
CREATE DATABASE TelloDrone_DB
ON PRIMARY
(
NAME = TelloDrone_Data1,
FILENAME = 'C:\test1\PrimaryDBfile.mdf',
SIZE = 2MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 4%
),
FILEGROUP SECONDARY
(
NAME = TelloDrone_Data2Secondary,
FILENAME = 'C:\test1\SecondaryDBfile.ndf',
SIZE = 10MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 2%
)
LOG ON
(
NAME = TelloLog,
FILENAME = 'C:\test\LogDBfile.ldf',
SIZE = 2MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 1%
)

USE TelloDrone_DB
GO

--Creation of Tables
--Crops
CREATE TABLE Crops
(
CropID INT PRIMARY KEY IDENTITY (1, 1),
Weat VARCHAR(25),
Corn VARCHAR(25),
Grapes VARCHAR(25),
Potatos VARCHAR(25),
Cotton VARCHAR(25),
SoyBean VARCHAR(25),
Apples VARCHAR(25),
--Better
Citrus VARCHAR(25),
Fruit VARCHAR(25),
Veg VARCHAR(25)
)

--LiveStock
CREATE TABLE LiveStock
(
LiveStockID INT PRIMARY KEY IDENTITY (1, 1),
Pig VARCHAR(25),
Cow VARCHAR(25),
Sheep VARCHAR(25),
Chicken VARCHAR(25)
)

--FieldProblems
CREATE TABLE FieldProblems
(
FieldProblemsID INT PRIMARY KEY IDENTITY (1, 1),
Error1 VARCHAR(35),
Error2 VARCHAR(35),
Error3 VARCHAR(35)
)

--Identifications
CREATE TABLE Identifications
(
IdentificationsID INT PRIMARY KEY IDENTITY (1, 1),
Crop VARCHAR(25),
Soil VARCHAR(25),
Insects VARCHAR(25),
Erosion VARCHAR(25),
WaterSaturation VARCHAR(25),
WaterSource VARCHAR(25),
FieldProblemsID INT FOREIGN KEY REFERENCES FieldProblems(FieldProblemsID),
)

--FieldInfo
CREATE TABLE FieldInfo
(
--This will be the main table that will be populated through the use of the program and displayed to the GUI
FieldInfoID INT PRIMARY KEY IDENTITY (1, 1),
Information VARCHAR(25),
CropID INT FOREIGN KEY REFERENCES Crops(CropID),
LiveStockID INT FOREIGN KEY REFERENCES LiveStock(LiveStockID),
FieldProblemsID INT FOREIGN KEY REFERENCES FieldProblems(FieldProblemsID),
GroundType VARCHAR(25)
)

--Drone
CREATE TABLE Drone
(
DroneID INT PRIMARY KEY IDENTITY (1, 1),
DroneName VARCHAR(25),
DroneType VARCHAR(25),
DroneStatus VARCHAR(25),
DroneLocation VARCHAR(25),
Manufacturer VARCHAR(25),
FieldInfoID INT FOREIGN KEY REFERENCES FieldInfo(FieldInfoID)
)

--FieldCrop
CREATE TABLE FieldCrop
(
FieldInfoID INT FOREIGN KEY REFERENCES FieldInfo(FieldInfoID),
CropID INT FOREIGN KEY REFERENCES Crops(CropID)
)

--FieldLiveStock
CREATE TABLE FieldLiveStock
(
FieldInfoID INT FOREIGN KEY REFERENCES FieldInfo(FieldInfoID),
LiveStockID INT FOREIGN KEY REFERENCES LiveStock(LiveStockID),
)

--Batch END

--Creation of Queries and Views

--Selecting all data in Drone table ;)

SELECT * FROM Drone

--Stored procedure

USE TelloDrone_DB
GO

CREATE VIEW vDroneLocation AS 
SELECT 
Drone.DroneID, 
Drone.DroneLocation
FROM Drone
