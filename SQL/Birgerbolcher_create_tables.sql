--CREATE DATABASE BirgerBolcher

USE Birgerbolcher

CREATE TABLE Farve
(
Idfarve INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Navnfarve NVARCHAR (20) NOT NULL
)

CREATE TABLE Smag_type
(
IdSmag_type INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
NavnSmag_type NVARCHAR (20) NOT NULL
)

CREATE TABLE Smag_styke
(
IdSmag_styke INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
NavnSmag_styke NVARCHAR (15) NOT NULL
)

CREATE TABLE Smag_Surhed
(
IdSmag_Surhed INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
NavnSmag_surhed NVARCHAR (20) NOT NULL
)

CREATE TABlE Bolcher
(
IdBolcher INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
NavnBolcher NVARCHAR(20) NOT NULL,
Farve_Idfarve INT FOREIGN KEY REFERENCES Farve(Idfarve),
Weightbolcher INT NOT NULL,
Smag_surhed_Id INT FOREIGN KEY REFERENCES Smag_surhed(IdSmag_surhed),
Smag_styke_Id INT FOREIGN KEY REFERENCES Smag_styke(IdSmag_styke),
Smag_type_Id INT FOREIGN KEY REFERENCES Smag_type(IdSmag_type),
Prisbolcher INT NOT NULL
)