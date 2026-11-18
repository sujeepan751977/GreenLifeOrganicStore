using System;

namespace GreenLifeOrganicStore.Models
{

    public class Product
    {

        public string ProductId { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string Supplier { get; set; }

        public int DiscountPercent { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
