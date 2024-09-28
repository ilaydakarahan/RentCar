using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.RentACarDto;

namespace RentCar.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.Title1 = "Araçlar";
            ViewBag.Title2 = "Uygun Araçlar";

            var locationId = TempData["locationId"];

            id = int.Parse(locationId.ToString());

            ViewBag.locationId = locationId;


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7214/api/RentACars?locationId={id}&available=true");

            if (responseMessage.IsSuccessStatusCode)
            {
                var content = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(content);   
                //Burda listeleme işleminin sonucunda filterrentacardto'yu dönüyor.O yğzden araç bilgilari yazıyor bu dto da.
                return View(values);
            }

            return View();
        }
    }
}
