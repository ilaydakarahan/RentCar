﻿using Microsoft.AspNetCore.Mvc;

namespace RentCar.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title1 = "Hakkımızda";
            ViewBag.Title2 = "Biz Kimiz ?";
            return View();
        }
    }
}
