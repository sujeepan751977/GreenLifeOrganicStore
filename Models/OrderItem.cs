namespace GreenLifeOrganicStore.Models
{

    public class OrderItem
    {

        public string ProductId { get; set; }

        public string ProductNameSnapshot { get; set; }

        public decimal UnitPriceSnapshot { get; set; }

        public int Quantity { get; set; }

        public decimal LineTotal => UnitPriceSnapshot * Quantity;
    }
}
