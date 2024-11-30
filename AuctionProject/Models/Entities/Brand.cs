using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
