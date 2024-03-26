USE master
CREATE DATABASE DOITHotel_BCTFO
USE DOITHotel_BCTFO

CREATE TABLE Managers
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL
)

INSERT INTO Managers(FirstName,LastName)
VALUES
(N'გიორგი',N'გიორგაძე'),
(N'თამაზი',N'გოდერძიშვილი'),
(N'გიორგი',N'გუჯარელიძე')



CREATE TABLE Hotels
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	Rating FLOAT NOT NULL,
	Country NVARCHAR(50) NOT NULL,
	City NVARCHAR(50) NOT NULL,
	PhyisicalAddress NVARCHAR(50) NOT NULL,
	ManagerId INT UNIQUE FOREIGN KEY REFERENCES Managers(Id)
)


--CREATE PROCEDURE sp_addManager
--	@firstName NVARCHAR(50),
--	@lastName NVARCHAR(50)
--AS
--BEGIN
--	INSERT INTO Managers(FirstName,LastName)
--	VALUES(@firstName,@lastName)
--END



--CREATE PROCEDURE sp_GetAllManagers
--AS
--BEGIN
--	SELECT [Id]
--		  ,[FirstName]
--		  ,[LastName]
--	FROM [DOITHotel_BCTFO].[dbo].[Managers]	
--END


 --CREATE PROCEDURE sp_UpdateManager
 --	@firstName NVARCHAR(50),
	--@lastName NVARCHAR(50),
	--@id INT
 --AS
 --BEGIN
	--UPDATE Managers
	--   SET FirstName = @firstName
	--	  ,LastName = @lastName
	-- WHERE Id = @id
 --END



 -- CREATE PROCEDURE sp_DeleteManager
	--@id INT
 --AS
 --BEGIN
	--DELETE Managers WHERE Id = @id
 --END