--USE BirgerBolcher

CREATE OR ALTER PROCEDURE Se_random_bolche
AS
BEGIN
	SELECT TOP 1 
	Bolcher.IdBolcher,
	Bolcher.Navnbolcher,
	Farve.Navnfarve,
	Bolcher.Weightbolcher,
	Smag_Surhed.NavnSmag_surhed,
	Smag_styke.NavnSmag_styke,
	Smag_type.NavnSmag_type,
	Bolcher.Prisbolcher
	FROM ((((Bolcher
	INNER JOIN Farve ON Bolcher.Farve_Idfarve = Farve.Idfarve)
	INNER JOIN Smag_Surhed ON Bolcher.Smag_surhed_Id = Smag_Surhed.IdSmag_Surhed)
	INNER JOIN Smag_styke ON Bolcher.Smag_styke_Id = Smag_styke.IdSmag_styke)
	INNER JOIN Smag_type ON Bolcher.Smag_type_Id = Smag_type.IdSmag_type)
	ORDER BY NEWID()
	END