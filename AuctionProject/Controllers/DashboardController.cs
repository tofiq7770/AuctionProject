﻿using Microsoft.AspNetCore.Mvc;

namespace AuctionProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
