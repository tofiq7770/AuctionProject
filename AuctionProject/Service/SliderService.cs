using AuctionProject.DAL;
using AuctionProject.Models.Entities;
using AuctionProject.Service.Interface;

namespace AuctionProject.Service
{
    public class SliderService : GenericService<Slider>, ISliderService
    {
        public SliderService(AppDbContext context) : base(context)
        {
        }

        
    }
}
