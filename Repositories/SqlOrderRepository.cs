using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Utils;

namespace GreenLifeOrganicStore.Repositories
{

    public class SqlOrderRepository : IRepository<Order>
    {

        public List<Order> GetAll()
        {
            var orders = new List<Order>();
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Orders ORDER BY OrderDate DESC", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = MapOrder(reader);
                        orders.Add(order);
                    }
                }
                // Load items for each order
                foreach (var order in orders)
                {
                    order.Items = GetItemsForOrder(order.OrderId, conn);
                }
            }
            return orders;
        }

        public Order GetById(string id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Orders WHERE OrderId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var order = MapOrder(reader);
                        reader.Close();
                        order.Items = GetItemsForOrder(order.OrderId, conn);
                        return order;
                    }
                }
            }
            return null;
        }

        public void Add(Order order)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        var cmd = new SqlCommand("INSERT INTO Orders (OrderId, CustomerId, OrderDate, Status, DiscountTotal) VALUES (@Id, @CustId, @Date, @Status, @Disc)", conn, trans);
                        cmd.Parameters.AddWithValue("@Id", order.OrderId);
                        cmd.Parameters.AddWithValue("@CustId", order.CustomerId);
                        cmd.Parameters.AddWithValue("@Date", order.OrderDate);
                        cmd.Parameters.AddWithValue("@Status", (int)order.Status);
                        cmd.Parameters.AddWithValue("@Disc", order.DiscountTotal);
                        cmd.ExecuteNonQuery();
                        foreach (var item in order.Items)
                        {
                            var itemCmd = new SqlCommand("INSERT INTO OrderItems (OrderId, ProductId, ProductNameSnapshot, UnitPriceSnapshot, Quantity) VALUES (@OrderId, @ProdId, @Name, @Price, @Qty)", conn, trans);
                            itemCmd.Parameters.AddWithValue("@OrderId", order.OrderId);
                            itemCmd.Parameters.AddWithValue("@ProdId", item.ProductId);
                            itemCmd.Parameters.AddWithValue("@Name", item.ProductNameSnapshot);
                            itemCmd.Parameters.AddWithValue("@Price", item.UnitPriceSnapshot);
                            itemCmd.Parameters.AddWithValue("@Qty", item.Quantity);
                            itemCmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(Order order)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE Orders SET Status = @Status, DiscountTotal = @Disc WHERE OrderId = @Id", conn);
                cmd.Parameters.AddWithValue("@Status", (int)order.Status);
                cmd.Parameters.AddWithValue("@Disc", order.DiscountTotal);
                cmd.Parameters.AddWithValue("@Id", order.OrderId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Orders WHERE OrderId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAll(List<Order> entities)
        {
            foreach (var o in entities) Update(o);
        }

        private Order MapOrder(SqlDataReader reader)
        {
            return new Order
            {
                OrderId = reader["OrderId"].ToString(),
                CustomerId = reader["CustomerId"].ToString(),
                OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                Status = (OrderStatus)Convert.ToInt32(reader["Status"]),
                DiscountTotal = Convert.ToDecimal(reader["DiscountTotal"])
            };
        }

        private List<OrderItem> GetItemsForOrder(string orderId, SqlConnection conn)
        {
            var items = new List<OrderItem>();
            var cmd = new SqlCommand("SELECT * FROM OrderItems WHERE OrderId = @OrderId", conn);
            cmd.Parameters.AddWithValue("@OrderId", orderId);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    items.Add(new OrderItem
                    {
                        ProductId = reader["ProductId"].ToString(),
                        ProductNameSnapshot = reader["ProductNameSnapshot"].ToString(),
                        UnitPriceSnapshot = Convert.ToDecimal(reader["UnitPriceSnapshot"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    });
                }
            }
            return items;
        }
    }
}
