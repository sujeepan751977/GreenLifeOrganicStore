using System.Collections.Generic;
using GreenLifeOrganicStore.Models;

namespace GreenLifeOrganicStore.Services
{

    public interface IReportService
    {
        decimal GetTotalSales();
        int GetTotalOrders();
        Dictionary<string, decimal> GetSalesByDay();
        List<Product> GetStockReport();
        List<Order> GetCustomerOrderHistory(string customerId);
    }
}
