CREATE TABLE orders (
    id INT IDENTITY(1,1) PRIMARY KEY,
    customer_name NVARCHAR(100) NULL,
    stock_id INT FOREIGN KEY REFERENCES stocks(id),
    quantity INT NOT NULL,
    unit_price DECIMAL(10,2) NOT NULL,
    discount DECIMAL(5,2) NULL,  -- discount can be NULL (optional)
    order_date DATETIME DEFAULT GETDATE(),
    status BIT DEFAULT 1,
    staff_id INT FOREIGN KEY REFERENCES staffs(id),
    total_before_discount AS (quantity * unit_price) PERSISTED,
    total_after_discount AS (
        quantity * unit_price * 
        (1 - ISNULL(discount, 0) / 100.0)
    ) PERSISTED,

    
);
    SELECT * FROM orders;