using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Order : BaseEntity
    {
        public int AuctionID { get; set; } // Foreign Key to Auction
        public string BuyerID { get; set; } // Foreign Key to AppUser (Buyer)
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentStatus { get; set; } // Pending, Paid, Failed

        // Navigation Properties
        public Auction Auction { get; set; } // One-to-One with Auction
        public AppUser Buyer { get; set; } // Many-to-One with AppUser
    }
}
