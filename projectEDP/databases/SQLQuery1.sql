CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    fullname VARCHAR(100),
    username VARCHAR(50),
    password VARCHAR(255),
    role VARCHAR(10) CHECK (role IN ('admin','staff','customer'))
);

CREATE TABLE orders (
    id INT IDENTITY(1,1) PRIMARY KEY,
    customer_name VARCHAR(100),
    phone VARCHAR(20),
    service_type VARCHAR(50),
    weight DECIMAL(5,2),
    total_price DECIMAL(10,2),
    order_date DATE,
    pickup_date DATE,
    status VARCHAR(50),
    notes NVARCHAR(500)
);

CREATE TABLE feedback (
    id INT IDENTITY(1,1) PRIMARY KEY,
    customer_name VARCHAR(100),
    rating INT,
    comment TEXT
);

CREATE TABLE contact (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100),
    message TEXT
);