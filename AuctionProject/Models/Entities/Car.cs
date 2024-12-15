using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Car : BaseEntity
    {
        public string SellerID { get; set; } // Foreign Key to AppUser
        public int ModelID { get; set; } // Foreign Key to Model
        public int Year { get; set; }
        public string Condition { get; set; } // New, Used, Damaged
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public DateTime DateAdded { get; set; }
        public int ColorID { get; set; } // Foreign Key to Color
        public List<CarImage> Images { get; set; } // One-to-Many with CarImage

        // Navigation Properties
        public Color Color { get; set; } // Many-to-One with Color

        public AppUser Seller { get; set; } // Many-to-One with AppUser
        public Auction Auction { get; set; } // One-to-One with Auction
        public List<CarCategory> CarCategories { get; set; } // Many-to-Many with Categories
        public Model Model { get; set; } // Many-to-One with Model
    }
}
