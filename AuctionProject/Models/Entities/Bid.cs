

using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Bid : BaseEntity
    {
        public int AuctionId { get; set; }
        public Auction Auction { get; set; }
        public decimal BidAmount { get; set; }
        public DateTime BidTime { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}