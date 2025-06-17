USE [CafeShop Management]
CREATE TABLE staffs (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    gender NVARCHAR(10) CHECK (gender IN ('Male', 'Female')),
    position NVARCHAR(50),
    email NVARCHAR(100) UNIQUE,
    phone NVARCHAR(20),
    hired_date DATE DEFAULT GETDATE(),
    profile_image NVARCHAR(255),
    status BIT DEFAULT 1 -- 1 = Active, 0 = Inactive
);

select * from staffs;
