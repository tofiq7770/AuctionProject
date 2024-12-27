using AuctionProject.DAL;
using AuctionProject.Models.Entities;
using AuctionProject.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo slidersInfo = await _context.SliderInfos.FirstOrDefaultAsync();  

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = slidersInfo,

            };
            return View(model);
        }
    }
}