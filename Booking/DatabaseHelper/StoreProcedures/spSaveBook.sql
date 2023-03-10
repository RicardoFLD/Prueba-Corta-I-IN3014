ALTER PROCEDURE [dbo].[spSaveBooking] 
	@BookId INT,
    @Email VARCHAR(350),
    @Checkin DATETIME,
    @Checkout DATETIME,
    @Adults INT,
    @Kids INT,
    @Nights INT,
    @Cost DECIMAL(15,2),
    @Total DECIMAL(15,2)
AS
BEGIN
    INSERT INTO Bookings ([BookId], [Email], [Checkin], [Checkout], [Adults], [Kids], [Nights], [Cost], [Total])
    VALUES (@BookId, @Email, @Checkin, @Checkout, @Adults, @Kids, @Nights, @Cost, @Total);
END