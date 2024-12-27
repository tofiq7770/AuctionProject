using AuctionProject.Areas.Admin.ViewModelsAdmin.Slider;
using AuctionProject.Models.Entities;
using AuctionProject.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AuctionProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly IGenericService<Slider> _genericService;
        public SliderController(IGenericService<Slider> genericService)
        {
            _genericService = genericService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var sliders = await _genericService.GetAllAsync();

            return View(sliders);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderCreateVM request)
        {

            return View();
        }
    }
}
