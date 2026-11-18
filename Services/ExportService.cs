using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GreenLifeOrganicStore.Models;

namespace GreenLifeOrganicStore.Services
{

    public class ExportService
    {

        public void ExportCustomerOrderHistoryToCsv(string customerName, List<Order> orders, string filePath)
        {
            try
            {
                var csv = new StringBuilder();
                csv.AppendLine("Order ID,Date,Status,Items Count,Total Amount");
                foreach (var order in orders)
                {
                    csv.AppendLine($"{order.OrderId},{order.OrderDate:yyyy-MM-dd HH:mm},{order.Status},{order.Items.Count},{order.GrandTotal}");
                }
                File.WriteAllText(filePath, csv.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Export failed: {ex.Message}", ex);
            }
        }

        public void ExportOrdersToCsv(List<Order> orders, string filePath)
        {
            try
            {
                var csv = new StringBuilder();
                csv.AppendLine("Order ID,Date,Status,Total Amount");
                foreach (var order in orders)
                {
                    csv.AppendLine($"{order.OrderId},{order.OrderDate:yyyy-MM-dd HH:mm},{order.Status},{order.GrandTotal}");
                }
                File.WriteAllText(filePath, csv.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Export failed: {ex.Message}", ex);
            }
        }
    }
}
