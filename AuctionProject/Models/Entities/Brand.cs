using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public List<Model> Models { get; set; } = new List<Model>();

    }
}
