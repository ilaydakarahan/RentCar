using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.ServiceDto;

namespace RentCar.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title1 = "Hizmetler";
            ViewBag.Title2 = "Tüm Hizmetler";

            return View();
        }
    }
}
