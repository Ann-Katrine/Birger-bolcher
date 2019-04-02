--USE BirgerBolcher

CREATE OR ALTER PROCEDURE tungeste_3_bolcher
AS
BEGIN
	SELECT TOP 3 Weightbolcher, NavnBolcher
	FROM Bolcher  
	ORDER BY Weightbolcher DESC
END