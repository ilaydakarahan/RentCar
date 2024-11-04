using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.CarDto;
using RentCar.Dto.CarPricingDto;
using RentCar.Dto.ServiceDto;

namespace RentCar.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title1 = "Araçlarımız";
            ViewBag.Title2 = "Aracınızı Seçiniz";


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7214/api/CarPricings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarPricingWithCarDto>>(jsonData);
                return View(values);
            }
            return View();
        }


        public async Task<IActionResult> CarDetail(int id)
        {
            ViewBag.CarId = id;
            ViewBag.Title1 = "Araç Detayları";
            ViewBag.Title2 = "Aracın Özellikleri";

            return View();

        }
    }
}
