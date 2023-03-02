USE [Booking]

CREATE PROCEDURE [dbo].[spGetResort] 
	 @id INT
AS
BEGIN
	
	SELECT 
		id, 
		name, 
		description,
		photo,
		price
	FROM Resorts
	WHERE id = @id
	
END
