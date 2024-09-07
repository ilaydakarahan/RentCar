using Microsoft.AspNetCore.Mvc;

namespace RentCar.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
