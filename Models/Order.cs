using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenLifeOrganicStore.Models
{

    public class Order
    {

        public string OrderId { get; set; } = Guid.NewGuid().ToString();

        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public decimal Subtotal => Items.Sum(i => i.LineTotal);

        public decimal DiscountTotal { get; set; }

        public decimal GrandTotal => Subtotal - DiscountTotal;
    }
}
