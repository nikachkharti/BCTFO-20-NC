--USE master
--CREATE DATABASE DOITHotel_BCTFO
--USE DOITHotel_BCTFO

--CREATE TABLE Hotels
--(
--	Id INT PRIMARY KEY IDENTITY NOT NULL,
--	[Name] NVARCHAR(50) NOT NULL,
--	Rating FLOAT NOT NULL,
--	Country NVARCHAR(50) NOT NULL,
--	City NVARCHAR(50) NOT NULL,
--	PhyisicalAddress NVARCHAR(50) NOT NULL
--)

--INSERT INTO Hotels([Name],Rating,Country,City,PhyisicalAddress)
--VALUES
--(N'პირველი სასტუმრო',9.3,N'საქართველო',N'თბილისი',N'რუსთაველის 4'),
--(N'მეორე სასტუმრო',8.0,N'საქართველო',N'ბათუმი',N'გამსახურიდას 12'),
--(N'მესამე სასტუმრო',7.7,N'საქართველო',N'თბილისი',N'პეკინის 13')



--CREATE PROCEDURE sp_GetAllHotels
--AS
--BEGIN
--	SELECT
--		Id,
--		[Name],
--		Rating,
--		Country,
--		City,
--		PhyisicalAddress
--	FROM Hotels
--END


--CREATE PROCEDURE sp_AddHotel
--@name NVARCHAR(50),
--@rating FLOAT,
--@country NVARCHAR(50),
--@city NVARCHAR(50),
--@phyisicalAddress NVARCHAR(50)
--AS
--BEGIN
--	INSERT INTO Hotels ([Name],Rating,Country,City,PhyisicalAddress)
--	VALUES
--	(@name,@rating,@country,@city,@phyisicalAddress)
--END

--CREATE PROCEDURE sp_UpdateHotel
--@name NVARCHAR(50),
--@rating FLOAT,
--@country NVARCHAR(50),
--@city NVARCHAR(50),
--@phyisicalAddress NVARCHAR(50),
--@hotelId INT
--AS
--BEGIN
--	UPDATE Hotels
--	SET
--		[Name] = @name,
--		Rating = @rating,
--		Country = @country,
--		City = @city,
--		PhyisicalAddress = @phyisicalAddress
--	WHERE Id = @hotelId
--END


--CREATE PROCEDURE sp_DeleteHotel
--@hotelId INT
--AS
--BEGIN
--	DELETE FROM Hotels WHERE Id = @hotelId
--END


--CREATE TABLE Managers
--(
--	Id INT PRIMARY KEY IDENTITY NOT NULL,
--	FirstName NVARCHAR(50) NOT NULL,
--	LastName NVARCHAR(50) NOT NULL,
--	HotelId INT UNIQUE FOREIGN KEY REFERENCES Hotels(Id)
--)

--INSERT INTO Managers(FirstName,LastName,HotelId)
--VALUES
--(N'გიორგი',N'გიორგაძე',1),
--(N'თამაზი',N'გოდერძიშვილი',2),
--(N'გიორგი',N'გუჯარელიძე',3)




--CREATE PROCEDURE sp_addManager
--	@firstName NVARCHAR(50),
--	@lastName NVARCHAR(50),
--	@hotelId INT
--AS
--BEGIN
--	INSERT INTO Managers(FirstName,LastName,HotelId)
--	VALUES(@firstName,@lastName,@hotelId)
--END



--CREATE PROCEDURE sp_GetAllManagers
--AS
--BEGIN
--	SELECT [Id]
--		  ,[FirstName]
--		  ,[LastName]
--		  ,[HotelId]
--	FROM [DOITHotel_BCTFO].[dbo].[Managers]	
--END


 --CREATE PROCEDURE sp_UpdateManager
 --	@firstName NVARCHAR(50),
	--@lastName NVARCHAR(50),
	--@hotelId INT,
	--@id INT
 --AS
 --BEGIN
	--UPDATE Managers
	--   SET FirstName = @firstName
	--	  ,LastName = @lastName
	--	  ,HotelId = @hotelId
	-- WHERE Id = @id
 --END



--CREATE PROCEDURE sp_DeleteManager
--	@id INT
-- AS
-- BEGIN
--	DELETE Managers WHERE Id = @id
-- END


  --ALTER TABLE Hotels ADD CONSTRAINT CK_ValidRating
  --CHECK(Rating >= 1.0 AND Rating <= 10.0)