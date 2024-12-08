using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Auction : BaseEntity
    {

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public decimal StartingPrice { get; set; }
        public string Status { get; set; }  // E.g., "Active" or "Closed"

        // Navigation properties
        public int CarId { get; set; }
        public Car Car { get; set; }
        public List<Bid> Bids { get; set; }
    }
}
