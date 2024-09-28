using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using NuGet.Common;
using RentCar.Dto.LocationDto;
using System.Net.Http.Headers;

namespace RentCar.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7214/api/Locations");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
                List<SelectListItem> selectListItems = (from x in values
                                                        select new SelectListItem
                                                        {
                                                            Text = x.Name,
                                                            Value = x.LocationId.ToString()
                                                        }).ToList();
                ViewBag.Locations = selectListItems;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(string locationId, string pickUpDate, string dropOffDate, string pickUpTime, string dropOffTime)
        {
            TempData["locationId"] = locationId;
            TempData["pickUpDate"] = pickUpDate;
            TempData["dropOffDate"] = dropOffDate;
            TempData["pickUpTime"] = pickUpTime;
            TempData["dropOffTime"] = dropOffTime;
            return RedirectToAction("Index", "RentACarList");
        }
    }
}
