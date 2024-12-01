using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Car : BaseEntity
    {

        public int Year { get; set; }
        public int Mileage { get; set; }
        //public string LicensePlate { get; set; } = string.Empty;
        public string Condition { get; set; }
        public decimal StartingPrice { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal StartingBid { get; set; }
        public decimal CurrentBid { get; set; }
        public decimal ReservePrice { get; set; }

        public DateTime AuctionEndTime { get; set; }
        public string AuctionStatus { get; set; } = "Active";
        public int ModelId { get; set; }

        public Model Model { get; set; }

        public int ColorID { get; set; }
        public Color Color { get; set; }

        public Auction Auction { get; set; }
        public List<Bid> Bids { get; set; } = new List<Bid>();

    }
}
/*
using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Car : BaseEntity
    {
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Condition { get; set; }
        public decimal StartingBid { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        // Auction-related fields moved to Auction model
        public decimal ReservePrice { get; set; }

        // Foreign Keys for related entities
        public int ModelId { get; set; }
        public Model Model { get; set; }

        public int ColorID { get; set; }
        public Color Color { get; set; }

        // Navigation properties
        public List<Bid> Bids { get; set; } = new List<Bid>();
    }
}

*/
