
-- Ejercicio 1 - Table Per Hierarchy (TPH)


-- a- Crear la base para el ejercicio 1

USE master;

GO

DROP DATABASE IF EXISTS GUIA21_1_Geometria_DB;

GO

CREATE DATABASE GUIA21_1_Geometria_DB

GO

USE GUIA21_1_Geometria_DB;

GO

-- b- Crear las tablas

CREATE TABLE Figuras(
	Id INT PRIMARY KEY IDENTITY(1,1),	
	Tipo INT NOT NULL,
	Area DECIMAL(18, 2),
	Ancho DECIMAL(18,2), 
	Largo DECIMAL(18,2),
	Radio DECIMAL(18,2)
);

GO

-- c- Insertar figuras como ejemplo
DECLARE @Ids TABLE(Id INT);
DECLARE @Id INT;

INSERT INTO Figuras(Tipo, Ancho, Largo, Radio) 
OUTPUT INSERTED.Id INTO @Ids 
VALUES
(1, 1,    1,    NULL),
(1, 1,    2,    NULL),
(2, NULL, NULL, 1),
(1, 2.2,    1,    NULL),
(2, NULL, NULL, 2.1);

SELECT TOP 1 @Id=Id FROM @Ids

SELECT @Id




SELECT f.Id,
	   CASE WHEN f.Tipo=1 THEN 'Rectangulo'
			WHEN f.Tipo=2 THEN 'Circulo'
	   ELSE 'Desconocido' END AS Tipo,
	   f.Area,
	   f.Ancho,
	   f.Largo,
	   f.Radio
FROM Figuras f;

GO

CREATE OR ALTER PROCEDURE sp_CalcularAreas
AS
BEGIN
	DECLARE Figura_CURSOR CURSOR FOR 
	SELECT Id, Tipo, Area, Ancho, Largo, Radio 
	FROM Figuras;

	OPEN Figura_CURSOR;

	DECLARE @Id NUMERIC(18,2), @Tipo INT, @Area NUMERIC(18,2),
	@Ancho NUMERIC(18,2), @Largo NUMERIC(18,2), @Radio NUMERIC(18,2);

	FETCH NEXT 
	FROM Figura_CURSOR INTO @Id, @Tipo, @Area, @Ancho, @Largo, @Radio;

	WHILE @@FETCH_STATUS=0
	BEGIN

		IF @Tipo=1
		BEGIN 
			SET @Area=@Ancho*@Largo;			
		END
		ELSE IF @Tipo=2
		BEGIN
			SET @Area=3.1415*POWER(@Radio,2);
		END

		UPDATE Figuras SET Area=@Area 
		WHERE Id=@Id;
		
		FETCH NEXT 
		FROM Figura_CURSOR INTO @Id, @Tipo, @Area, @Ancho, @Largo, @Radio;
	END 

	CLOSE Figura_CURSOR;
	DEALLOCATE Figura_CURSOR;

END

GO

EXEC  sp_CalcularAreas

SELECT f.Id,
	   CASE WHEN f.Tipo=1 THEN 'Rectangulo'
			WHEN f.Tipo=2 THEN 'Circulo'
	   ELSE 'Desconocido' END AS Tipo,
	   f.Area,
	   f.Ancho,
	   f.Largo,
	   f.Radio
FROM Figuras f


GO

USE master

GO