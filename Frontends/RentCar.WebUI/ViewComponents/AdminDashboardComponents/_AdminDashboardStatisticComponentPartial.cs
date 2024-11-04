using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.StatisticDto;

namespace RentCar.WebUI.ViewComponents.AdminDashboardComponents
{
    public class _AdminDashboardStatisticComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AdminDashboardStatisticComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random rnd = new Random();  //ProgressBar için random sayı atadım. Her kartta rastgele sayı oluşturacak.
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7214/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int rnd1 = rnd.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.carCount = values.carCount;
                ViewBag.rnd1 = rnd1;
            }

            var responseMessage2 = await client.GetAsync("https://localhost:7214/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int rnd2 = rnd.Next(0, 101);
                var jsonData = await responseMessage2.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.locationCount = values.locationCount;
                ViewBag.rnd2 = rnd2;
            }

            var responseMessage5 = await client.GetAsync("https://localhost:7214/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int rnd5 = rnd.Next(0, 101);
                var jsonData = await responseMessage5.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.brandCount = values.brandCount;
                ViewBag.rnd5 = rnd5;
            }

            var responseMessage6 = await client.GetAsync("https://localhost:7214/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int rnd6 = rnd.Next(0, 101);
                var jsonData = await responseMessage6.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.avgPriceForDaily = values.avgPriceForDaily;
                ViewBag.rnd6 = rnd6;
            }

            return View();
        }
    }
}
