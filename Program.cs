using System;
using System.IO;
using System.Windows.Forms;
using GreenLifeOrganicStore.Forms;
using GreenLifeOrganicStore.Utils;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Services;
using GreenLifeOrganicStore.Repositories;
using System.Collections.Generic;

namespace GreenLifeOrganicStore
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Global Exception Handling
            Application.ThreadException += (s, e) => HandleException(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => HandleException(e.ExceptionObject as Exception);
            InitializeData();
            Application.Run(new StartForm());
        }
        static void HandleException(Exception ex)
        {
            if (ex == null) return;
            Logger.LogError("Unhandled System Exception", ex);
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static void InitializeData()
        {
            try
            {
                // Create all missing tables first!
                using (var conn = new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();
                    string[] tableScripts = {
                        @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Admins')
                          CREATE TABLE Admins (Id NVARCHAR(50) PRIMARY KEY, FullName NVARCHAR(100), Email NVARCHAR(100), PasswordHash NVARCHAR(MAX), Role NVARCHAR(50), CreatedAt DATETIME)",
                        @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Customers')
                          CREATE TABLE Customers (Id NVARCHAR(50) PRIMARY KEY, FullName NVARCHAR(100), Email NVARCHAR(100), PasswordHash NVARCHAR(MAX), Phone NVARCHAR(50), Address NVARCHAR(MAX), CreatedAt DATETIME, LoyaltyPoints INT, TotalSpend DECIMAL(18,2), Role NVARCHAR(50))",
                        @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Products')
                          CREATE TABLE Products (ProductId NVARCHAR(50) PRIMARY KEY, Name NVARCHAR(100), Category NVARCHAR(50), Price DECIMAL(18,2), Stock INT, Supplier NVARCHAR(100), DiscountPercent INT, IsActive BIT)",
                        @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Orders')
                          CREATE TABLE Orders (OrderId NVARCHAR(50) PRIMARY KEY, CustomerId NVARCHAR(50), OrderDate DATETIME, Status INT, DiscountTotal DECIMAL(18,2))",
                        @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Reviews')
                          CREATE TABLE Reviews (ReviewId NVARCHAR(50) PRIMARY KEY, ProductId NVARCHAR(50), CustomerId NVARCHAR(50), Rating INT, Comment NVARCHAR(MAX), CreatedAt DATETIME DEFAULT GETDATE())"
                    };
                    foreach (var script in tableScripts)
                    {
                        using (var cmd = new System.Data.SqlClient.SqlCommand(script, conn)) { cmd.ExecuteNonQuery(); }
                    }
                }
                // Seed Admin if missing (now that table exists)
                var adminRepo = new SqlRepository<Admin>("Admins");
                var admins = adminRepo.GetAll();
                if (admins.Count == 0)
                {
                    adminRepo.Add(new Admin
                    {
                        Id = "A001",
                        FullName = "System Admin",
                        Email = "admin@greenlife.com",
                        PasswordHash = CryptoHelper.HashPassword("Admin@123"),
                        CreatedAt = DateTime.Now
                    });
                }
                // Seed sample products if missing
                var productRepo = new SqlRepository<Product>("Products", "ProductId");
                var products = productRepo.GetAll();
                if (products.Count == 0)
                {
                    productRepo.Add(new Product { ProductId = Guid.NewGuid().ToString(), Name = "Organic Apples", Category = "Fruits", Price = 5.99m, Stock = 50, Supplier = "EcoFarm", DiscountPercent = 0, IsActive = true });
                    productRepo.Add(new Product { ProductId = Guid.NewGuid().ToString(), Name = "Organic Spinach", Category = "Vegetables", Price = 2.50m, Stock = 30, Supplier = "GreenGrow", DiscountPercent = 5, IsActive = true });
                    productRepo.Add(new Product { ProductId = Guid.NewGuid().ToString(), Name = "Honey Pure", Category = "Pantry", Price = 12.00m, Stock = 5, Supplier = "BeeBest", DiscountPercent = 10, IsActive = true });
                }
            }
            catch (Exception ex)
            {
                // If SQL fails, we just log it. The provided SQL script should be run first.
                Console.WriteLine($"Database initialization failed: {ex.Message}");
                Logger.LogError("DB Init Fail", ex);
            }
        }
    }
}
