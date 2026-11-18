using System;

namespace GreenLifeOrganicStore.Models
{

    public class Review
    {

        public string ReviewId { get; set; } = Guid.NewGuid().ToString();

        public string ProductId { get; set; }

        public string CustomerId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
