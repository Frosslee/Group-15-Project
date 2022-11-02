------------------------------------------------------------------------------------------
--                                 Database Creation
------------------------------------------------------------------------------------------

CREATE DATABASE PRJ381
GO
USE PRJ381
GO

------------------------------------------------------------------------------------------
--                                 Tables Creation
------------------------------------------------------------------------------------------
CREATE TABLE Roles
(
RoleID INT NOT NULL PRIMARY KEY,
RoleName VARCHAR(200)
)
GO

CREATE TABLE Users
(
UserID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
UserName VARCHAR(200),
UserRole INT FOREIGN KEY REFERENCES Roles(RoleID),
UserPassword VARCHAR(200)
)
GO

CREATE TABLE Items
(
ID INT IDENTITY(1,1),
Picture IMAGE,
Description VARCHAR(200),
DateTaken DATETIME,
UserLog INT FOREIGN KEY REFERENCES Users(UserID)
)
GO



------------------------------------------------------------------------------------------
--                                 STORED PROCEDURES
------------------------------------------------------------------------------------------

--New User
CREATE OR ALTER PROCEDURE spNewUser
(
@Username VARCHAR(200),
@Role INT,
@UserPassword VARCHAR(200)
)
AS 
BEGIN
INSERT INTO Users (UserName, UserRole, UserPassword) 
VALUES (@Username, @Role, @UserPassword)
END
GO

--New Item
CREATE OR ALTER PROCEDURE spNewItem
(
@Pic IMAGE,
@Desc VARCHAR(200),
@Date DATETIME,
@Userlog INT
)
AS 
BEGIN
INSERT INTO Items (Picture, Description, DateTaken, UserLog)
VALUES (@Pic, @Desc, @Date, @Userlog)
END
GO

--Update Item
CREATE OR ALTER PROCEDURE spUpdateItem
(
@SearchID int,
@Pic IMAGE,
@Desc VARCHAR(200),
@Date DATETIME,
@Userlog INT
)
AS 
BEGIN
UPDATE Items
SET Picture = @Pic, Description = @Desc, DateTaken = @Date, UserLog = @Userlog
WHERE ID = @SearchID
END
GO

--Update User
CREATE OR ALTER PROCEDURE spUpdateUser
(
@UID int,
@Username VARCHAR(200),
@Role INT,
@UserPassword VARCHAR(200)
)
AS 
BEGIN
UPDATE Users
SET UserName = @Username, UserRole = @Role, UserPassword = @UserPassword
WHERE UserID = @UID
END
GO

--Log in
CREATE OR ALTER PROCEDURE spLogin
(
@Username VARCHAR(200),
@Password VARCHAR(200)
)
AS 
BEGIN
SELECT * FROM Users WHERE UserName = @Username AND UserPassword = @Password
END
GO