CREATE DATABASE Movie4Rent
GO

USE Movie4Rent
GO

CREATE TABLE Staff
(
	StaffID INT IDENTITY PRIMARY KEY,
	Username NVARCHAR(100),
	Password NVARCHAR(100),
)
GO


CREATE TABLE Importing
(
	ImportID INT IDENTITY PRIMARY KEY,
	StaffID INT,
	ImportDate DATETIME,
	TotalQuant INT,
	FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
)
GO

CREATE TABLE Exporting
(
	ExportID INT IDENTITY PRIMARY KEY,
	StaffID INT,
	ExportDate DATETIME,
	TotalQuant INT,
	FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
)

CREATE TABLE Movie
(
	MovieID INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(100),
	Actor NVARCHAR(100),
	Genre NVARCHAR(100),
	Description NVARCHAR(100),
	Director NVARCHAR(100),
	IMDB FLOAT,
	Poster image,
)
GO

CREATE TABLE ImportingDetail
(
	ImportID INT,
	MovieID INT,
	Quant INT,
		
	CONSTRAINT PK_ImportingDetail PRIMARY KEY (ImportID, MovieID), 
	CONSTRAINT FK_ImportingDetail_Import FOREIGN KEY (ImportID) REFERENCES Importing(ImportID) ON DELETE CASCADE,
	CONSTRAINT FK_ImportingDetail_Movie FOREIGN KEY (MovieID) REFERENCES Movie(MovieID),	
)
GO

CREATE Table ExportingDetail
(
	ExportID INT,
	MovieID INT,
	Quant INT,
		
	CONSTRAINT PK_EmportingDetail PRIMARY KEY (ExportID, MovieID),
	CONSTRAINT FK_ExportingDetail_Export FOREIGN KEY (ExportID) REFERENCES Exporting(ExportID) ON DELETE CASCADE,
	CONSTRAINT FK_ExportingDetail_Movie FOREIGN KEY (MovieID) REFERENCES Movie(MovieID),
)
GO

INSERT INTO Staff (Username, Password) VALUES (N'admin', N'admin')
GO

SELECT * FROM Staff