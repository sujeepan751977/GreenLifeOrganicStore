using System.Data.SqlClient;
using System;
class Program {
    static void Main() {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GreenLifeDB;Integrated Security=True";
        using(var c = new SqlConnection(cs)) {
            c.Open();
            try { new SqlCommand("ALTER TABLE Customers ADD TotalSpend DECIMAL(18,2) DEFAULT 0", c).ExecuteNonQuery(); } catch (Exception e) { Console.WriteLine(e.Message); }
            try { new SqlCommand("ALTER TABLE Customers ADD Role NVARCHAR(50) DEFAULT 'Customer'", c).ExecuteNonQuery(); } catch (Exception e) { Console.WriteLine(e.Message); }
            try { new SqlCommand("UPDATE Customers SET TotalSpend=0 WHERE TotalSpend IS NULL", c).ExecuteNonQuery(); } catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine("DB MIGRATED.");
        }
    }
}
