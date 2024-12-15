using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Auction : BaseEntity
    {
        public int CarID { get; set; } // Foreign Key to Car
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; } // Active, Completed, Cancelled
        public decimal CurrentHighestBid { get; set; }
        public string WinnerID { get; set; } // Foreign Key to AppUser (nullable)
        public string StripePaymentId { get; set; } // Reference to Stripe Payment
        public Order Order { get; set; } // One-to-One with Order
        // Navigation Properties
        public Car Car { get; set; } // One-to-One with Car
        public AppUser Buyer { get; set; } // Many-to-One with AppUser
        public List<Bid> Bids { get; set; } // One-to-Many with Bids
    }
}
