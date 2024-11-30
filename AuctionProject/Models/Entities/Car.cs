using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Condition { get; set; }
        public decimal StartingPrice { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public int ColorID { get; set; }
        public Color Color { get; set; }

        public Auction Auction { get; set; }
    }
}
