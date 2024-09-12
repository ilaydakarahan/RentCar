using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RentCar.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailMainComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}    
