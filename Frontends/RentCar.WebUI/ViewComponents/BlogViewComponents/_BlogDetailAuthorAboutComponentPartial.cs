using Microsoft.AspNetCore.Mvc;

namespace RentCar.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailAuthorAboutComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
