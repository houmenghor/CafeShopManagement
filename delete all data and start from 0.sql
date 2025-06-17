USE [CafeShop Management];
-- Step 1: Delete all data from the table
DELETE FROM sales;

-- Step 2: Reset the auto-increment ID to start from 1 (for SQL Server)
DBCC CHECKIDENT ('sales', RESEED, 0);

select * from sales