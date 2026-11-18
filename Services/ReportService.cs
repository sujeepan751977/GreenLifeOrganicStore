using System.Collections.Generic;
using System.Linq;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;

namespace GreenLifeOrganicStore.Services
{

    public class ReportService : IReportService
    {

        private readonly IRepository<Order> _orderRepo = new SqlOrderRepository();

        private readonly IRepository<Product> _productRepo = new SqlRepository<Product>("Products", "ProductId");

        public decimal GetTotalSales() => _orderRepo.GetAll().Sum(o => o.GrandTotal);

        public int GetTotalOrders() => _orderRepo.GetAll().Count;

        public Dictionary<string, decimal> GetSalesByDay()
        {
            return _orderRepo.GetAll()
                .GroupBy(o => o.OrderDate.ToShortDateString())
                .ToDictionary(g => g.Key, g => g.Sum(o => o.GrandTotal));
        }

        public List<Product> GetStockReport() => _productRepo.GetAll();

        public List<Order> GetCustomerOrderHistory(string customerId)
        {
            return _orderRepo.GetAll().Where(o => o.CustomerId == customerId).ToList();
        }
    }
}
