using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Bid : BaseEntity
    {
        public int AuctionID { get; set; }
        public decimal BidAmount { get; set; }
        public DateTime BidTime { get; set; }
        public Auction Auction { get; set; }
    }
}
