using System;
using System.Collections.Generic;
using System.Linq;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;
using GreenLifeOrganicStore.Utils;

namespace GreenLifeOrganicStore.Services
{

    public class OrderService
    {

        private readonly IRepository<Order> _orderRepo = new SqlOrderRepository();

        private readonly IRepository<Product> _productRepo = new SqlRepository<Product>("Products", "ProductId");

        private readonly IRepository<Customer> _customerRepo = new SqlRepository<Customer>("Customers");

        public List<Order> GetCustomerOrders(string customerId)
        {
            return _orderRepo.GetAll().Where(o => o.CustomerId == customerId).OrderByDescending(o => o.OrderDate).ToList();
        }

        public List<Order> GetAllOrders() => _orderRepo.GetAll().OrderByDescending(o => o.OrderDate).ToList();

        public Order GetLastOrder(string customerId)
        {
            return _orderRepo.GetAll()
                .Where(o => o.CustomerId == customerId)
                .OrderByDescending(o => o.OrderDate)
                .FirstOrDefault();
        }

        public string PlaceOrder(string customerId, List<OrderItem> items)
        {
            try
            {
                if (items == null || !items.Any()) return "Cart is empty.";
                var products = _productRepo.GetAll();
                
                // Check stock
                foreach (var item in items)
                {
                    var product = products.FirstOrDefault(p => p.ProductId == item.ProductId);
                    if (product == null) return $"Product {item.ProductNameSnapshot} not found.";
                    if (product.Stock < item.Quantity) return $"Insufficient stock for {product.Name}.";
                }
                // Deduct stock
                foreach (var item in items)
                {
                    var product = products.FirstOrDefault(p => p.ProductId == item.ProductId);
                    if (product != null)
                        product.Stock -= item.Quantity;
                }
                _productRepo.UpdateAll(products);
                var order = new Order
                {
                    CustomerId = customerId,
                    Items = items,
                    DiscountTotal = 0
                };
                _orderRepo.Add(order);
                Logger.LogInfo($"Order Placed: {order.OrderId} for Customer {customerId}. Total: {order.GrandTotal}");
                // Update Loyalty Rewards
                var customer = _customerRepo.GetById(customerId);
                if (customer != null)
                {
                    customer.TotalSpend += order.GrandTotal;
                    customer.LoyaltyPoints += (int)(order.GrandTotal / 10);
                    _customerRepo.Update(customer);
                    
                    // Sync session if it's the current user
                    if (Session.CurrentCustomer != null && Session.CurrentCustomer.Id == customer.Id)
                    {
                        Session.CurrentCustomer.TotalSpend = customer.TotalSpend;
                        Session.CurrentCustomer.LoyaltyPoints = customer.LoyaltyPoints;
                    }
                }
                return null; // Success
            }
            catch (Exception ex)
            {
                Logger.LogError("Checkout Failure", ex);
                return $"Unexpected Error: {ex.Message}";
            }
        }

        public List<Order> GetOrdersByDateRange(DateTime start, DateTime end)
        {
            return _orderRepo.GetAll()
                .Where(o => o.OrderDate.Date >= start.Date && o.OrderDate.Date <= end.Date)
                .OrderByDescending(o => o.OrderDate)
                .ToList();
        }

        public void UpdateOrderStatus(string orderId, OrderStatus status)
        {
            var order = _orderRepo.GetById(orderId);
            if (order != null)
            {
                order.Status = status;
                _orderRepo.Update(order);
            }
        }
    }
}
