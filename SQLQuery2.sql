CREATE TABLE Donations (
    DonationID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100),
    PhoneNumber NVARCHAR(15),
    Amount DECIMAL(10, 2),
    DonationDate DATETIME DEFAULT GETDATE()
);

SELECT * FROM Donations;