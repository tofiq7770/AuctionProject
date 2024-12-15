using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Model : BaseEntity
    {
        public string ModelName { get; set; } // Specific model name (e.g., Corolla, X5)
        public int BrandID { get; set; } // Foreign Key to Brand

        // Navigation Properties
        public Brand Brand { get; set; } // Many-to-One with Brand
        public List<Car> Cars { get; set; } // One-to-Many with Car
    }
}
