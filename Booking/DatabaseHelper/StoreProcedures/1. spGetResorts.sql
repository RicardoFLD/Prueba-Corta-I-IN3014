USE [Booking]

CREATE PROCEDURE [dbo].[spGetResorts] 
	
AS
BEGIN	
	SELECT 
		id, 
		name, 
		description,
		photo,
		price
	FROM Resorts	
END
