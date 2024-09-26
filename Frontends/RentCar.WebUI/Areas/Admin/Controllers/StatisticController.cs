using Microsoft.AspNetCore.Mvc;

namespace RentCar.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
