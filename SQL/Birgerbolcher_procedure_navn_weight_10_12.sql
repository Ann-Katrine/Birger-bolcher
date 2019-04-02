--USE BirgerBolcher

CREATE OR ALTER PROCEDURE navn_weight_10_12
AS
BEGIN
	SELECT
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
	WHERE Bolcher.Weightbolcher >= '10' AND Bolcher.Weightbolcher <= '12'
	ORDER By Bolcher.NavnBolcher, Bolcher.Weightbolcher
END