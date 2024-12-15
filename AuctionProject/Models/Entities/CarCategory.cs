using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class CarCategory : BaseEntity
    {
        public int CarCategoryID { get; set; } // Primary Key
        public int CarID { get; set; } // Foreign Key to Car
        public int CategoryID { get; set; } // Foreign Key to Category

        // Navigation Properties
        public Car Car { get; set; }
        public Category Category { get; set; }
    }
}
