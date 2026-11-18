-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'GreenLifeStore')
BEGIN
    CREATE DATABASE GreenLifeStore;
END
GO

USE GreenLifeStore;
GO

-- Admins Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admins]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Admins] (
        [Id] NVARCHAR(50) PRIMARY KEY,
        [FullName] NVARCHAR(100) NOT NULL,
        [Email] NVARCHAR(100) UNIQUE NOT NULL,
        [PasswordHash] NVARCHAR(255) NOT NULL,
        [Role] NVARCHAR(50) DEFAULT 'Admin',
        [CreatedAt] DATETIME DEFAULT GETDATE()
    );
END

-- Customers Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Customers] (
        [Id] NVARCHAR(50) PRIMARY KEY,
        [FullName] NVARCHAR(100) NOT NULL,
        [Email] NVARCHAR(100) UNIQUE NOT NULL,
        [PasswordHash] NVARCHAR(255) NOT NULL,
        [Phone] NVARCHAR(20),
        [Address] NVARCHAR(MAX),
        [Role] NVARCHAR(50) DEFAULT 'Customer',
        [CreatedAt] DATETIME DEFAULT GETDATE()
    );
END

-- Products Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Products] (
        [ProductId] NVARCHAR(50) PRIMARY KEY,
        [Name] NVARCHAR(100) NOT NULL,
        [Category] NVARCHAR(100),
        [Price] DECIMAL(18, 2) NOT NULL,
        [Stock] INT NOT NULL,
        [Supplier] NVARCHAR(100),
        [DiscountPercent] INT DEFAULT 0,
        [IsActive] BIT DEFAULT 1
    );
END

-- Orders Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Orders]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Orders] (
        [OrderId] NVARCHAR(50) PRIMARY KEY,
        [CustomerId] NVARCHAR(50) FOREIGN KEY REFERENCES Customers(Id),
        [OrderDate] DATETIME DEFAULT GETDATE(),
        [Status] INT DEFAULT 0, -- Matches OrderStatus Enum
        [DiscountTotal] DECIMAL(18, 2) DEFAULT 0
    );
END

-- OrderItems Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItems]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[OrderItems] (
        [OrderItemId] INT IDENTITY(1,1) PRIMARY KEY,
        [OrderId] NVARCHAR(50) FOREIGN KEY REFERENCES Orders(OrderId) ON DELETE CASCADE,
        [ProductId] NVARCHAR(50),
        [ProductNameSnapshot] NVARCHAR(100),
        [UnitPriceSnapshot] DECIMAL(18, 2),
        [Quantity] INT
    );
END

-- Reviews Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reviews]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Reviews] (
        [ReviewId] NVARCHAR(50) PRIMARY KEY,
        [ProductId] NVARCHAR(50) FOREIGN KEY REFERENCES Products(ProductId),
        [CustomerId] NVARCHAR(50) FOREIGN KEY REFERENCES Customers(Id),
        [Rating] INT CHECK (Rating >= 1 AND Rating <= 5),
        [Comment] NVARCHAR(MAX),
        [CreatedAt] DATETIME DEFAULT GETDATE()
    );
END

-- Seed Default Admin if none exists
IF NOT EXISTS (SELECT * FROM [dbo].[Admins])
BEGIN
    INSERT INTO [dbo].[Admins] (Id, FullName, Email, PasswordHash, Role)
    VALUES (N'A001', N'System Administrator', N'admin@gmail.com', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'Admin'); -- password: admin
END
GO
