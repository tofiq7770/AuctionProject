using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Model : BaseEntity
    {
        public string Name { get; set; }

        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

        public List<Car> Cars { get; set; }
    }
}
