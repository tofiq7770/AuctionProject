using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class CarImage : BaseEntity
    {
        public int CarID { get; set; } // Foreign Key to Car
        public string ImageUrl { get; set; } // URL or path to the car image
        public string Description { get; set; } // Optional description of the image

        // Navigation Properties
        public Car Car { get; set; } // Many-to-One with Car
    }
}
