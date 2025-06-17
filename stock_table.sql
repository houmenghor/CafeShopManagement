USE [CafeShop Management]
CREATE TABLE stocks (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    qty INT DEFAULT 0,
    created_at DATETIME DEFAULT GETDATE(),
    status BIT DEFAULT 1
);

select * from stocks 