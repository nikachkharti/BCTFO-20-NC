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