using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Color : BaseEntity
    {
        public string ColorName { get; set; }

        public List<Car> Cars { get; set; }
    }
}
