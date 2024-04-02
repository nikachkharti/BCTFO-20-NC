--USE master
--CREATE DATABASE DOITHotel_BCTFO
--USE DOITHotel_BCTFO

-----------------------------------------HOTELS-----------------------------------------

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


--CREATE PROCEDURE sp_GetSingleHotel
--@id INT
--AS
--BEGIN
--	SELECT*FROM Hotels
--	WHERE Id = @id
--END


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



-----------------------------------------MANAGERS-----------------------------------------


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



--CREATE PROCEDURE sp_GetSingleManager
--@id INT
--AS
--BEGIN
--	SELECT*FROM Managers
--	WHERE Id = @id
--END


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







-----------------------------------------ROOMS-----------------------------------------

--CREATE TABLE Rooms
--(
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	[Name] VARCHAR(25) NOT NULL,
--	IsFree BIT NOT NULL,
--	HotelId INT FOREIGN KEY REFERENCES Hotels(Id),
--	DailyPrice FLOAT NOT NULL
--)


--ALTER TABLE Rooms ADD CONSTRAINT CK_PositivePrice
--CHECK(DailyPrice > 0)




	--INSERT INTO Rooms([Name],IsFree,HotelId,DailyPrice)
	--VALUES
	--('A-100',0,1,50),
	--('A-200',0,1,50),
	--('A-300',1,1,50),
	--('B-100',0,1,100),
	--('B-200',1,1,100),
	--('B-300',0,1,100),
	--('C-100',1,1,200),
	--('C-200',0,1,200),
	--('C-300',1,1,200),
	--('100',1,2,25),
	--('101',1,2,25),
	--('102',1,2,25),
	--('200',0,2,50),
	--('201',0,2,50),
	--('202',0,2,50),
	--('300',1,2,75),
	--('301',1,2,75),
	--('302',0,2,75),
	--('A-10',1,3,150),
	--('A-20',0,3,150),
	--('A-30',1,3,150),
	--('B-10',1,3,150),
	--('B-20',0,3,150),
	--('B-30',1,3,150),
	--('C-10',1,3,150),
	--('C-20',0,3,150),
	--('C-30',1,3,150)




--	CREATE PROCEDURE sp_AddRoom
--@name VARCHAR(25),
--@isFree BIT,
--@hotelId INT,
--@dailyPrice FLOAT
--AS
--BEGIN
--	INSERT INTO Rooms([Name],IsFree,HotelId,DailyPrice)
--	VALUES(@name,@isFree,@hotelId,@dailyPrice)
--END


--CREATE PROCEDURE sp_GetAllRooms
--AS
--BEGIN
--	SELECT [Id]
--      ,[Name]
--      ,[IsFree]
--      ,[HotelId]
--      ,[DailyPrice]
--	FROM [DOITHotel_BCTFO].[dbo].[Rooms]
--END

--CREATE PROCEDURE sp_GetAllRoomsOfHotel
--@hotelId INT
--AS
--BEGIN
--	SELECT [Id]
--      ,[Name]
--      ,[IsFree]
--      ,[HotelId]
--      ,[DailyPrice]
--	FROM [DOITHotel_BCTFO].[dbo].[Rooms]
--	WHERE HotelId = @hotelId
--END


--CREATE PROCEDURE sp_DeleteRoom
--@id INT
--AS
--BEGIN
--	DELETE Rooms WHERE Id = @id
--END


--CREATE PROCEDURE sp_UpdateRoom
--@id INT,
--@name VARCHAR(25),
--@isFree BIT,
--@hotelId INT,
--@dailyPrice FLOAT
--AS
--BEGIN
--	UPDATE Rooms
--	SET
--	[Name] = @name,
--	IsFree = @isFree,
--	HotelId = @hotelId,
--	DailyPrice = @dailyPrice
--	WHERE Id = @id
--END


--CREATE PROCEDURE sp_GetSingleRoom
--@id INT
--AS
--BEGIN
--	SELECT*FROM Rooms
--	WHERE Id = @id
--END