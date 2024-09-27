using Microsoft.AspNetCore.Mvc;

namespace RentCar.WebUI.ViewComponents.RentACarFilterViewComponents
{
    public class _RentACarFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
