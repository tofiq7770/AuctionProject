using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Category : BaseEntity
    {
        public int CategoryID { get; set; } // Primary Key
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public ICollection<CarCategory> CarCategories { get; set; } // Many-to-Many with Cars
    }
}
