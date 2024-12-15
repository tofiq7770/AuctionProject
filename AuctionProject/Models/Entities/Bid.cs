using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Bid : BaseEntity
    {
        public int AuctionID { get; set; } // Foreign Key to Auction
        public string BidderID { get; set; } // Foreign Key to AppUser
        public decimal BidAmount { get; set; }
        public DateTime BidTime { get; set; }

        // Navigation Properties
        public Auction Auction { get; set; } // Many-to-One with Auction
        public AppUser Buyer { get; set; } // Many-to-One with AppUser
    }
}
