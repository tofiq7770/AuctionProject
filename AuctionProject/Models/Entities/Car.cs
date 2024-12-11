
using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Car : BaseEntity
    {
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Vin { get; set; }
        public string Condition { get; set; }
        public decimal StartingBid { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }


        public decimal ReservePrice { get; set; }

        // Foreign Keys for related entities
        public int ModelId { get; set; }
        public Model Model { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }

    }
}