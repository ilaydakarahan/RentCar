﻿using Microsoft.AspNetCore.Mvc;

namespace RentCar.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCategoryViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}