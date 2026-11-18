namespace GreenLifeOrganicStore.Models
{

    public class Customer : UserBase
    {

        public string Phone { get; set; }

        public string Address { get; set; }

        public int LoyaltyPoints { get; set; }

        public decimal TotalSpend { get; set; }

        public string Role { get; set; } = "Customer";
    }
}
