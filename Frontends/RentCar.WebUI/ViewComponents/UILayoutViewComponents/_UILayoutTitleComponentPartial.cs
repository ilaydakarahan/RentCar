using Microsoft.AspNetCore.Mvc;

namespace RentCar.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutTitleComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
