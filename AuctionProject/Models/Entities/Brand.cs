using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; } // Name of the brand (e.g., Toyota, BMW)

        // Navigation Properties
        public List<Model> Models { get; set; } // One-to-Many with Model
    }
}
