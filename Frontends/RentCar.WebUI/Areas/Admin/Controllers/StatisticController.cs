using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.AuthorDto;
using RentCar.Dto.StatisticDto;

namespace RentCar.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class StatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Index()
        {
            Random rnd = new Random();  //ProgressBar için random sayı atadım. Her kartta rastgele sayı oluşturacak.
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7214/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int rnd1 = rnd.Next(0,101);
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
            var responseMessage3 = await client.GetAsync("https://localhost:7214/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int rnd3 = rnd.Next(0, 101);
                var jsonData = await responseMessage3.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.authorCount = values.authorCount;
                ViewBag.rnd3 = rnd3;
            }

            var responseMessage4 = await client.GetAsync("https://localhost:7214/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int rnd4 = rnd.Next(0, 101);
                var jsonData = await responseMessage4.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.blogCount = values.blogCount;
                ViewBag.rnd4 = rnd4;
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

            var responseMessage7 = await client.GetAsync("https://localhost:7214/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int rnd7 = rnd.Next(0, 101);
                var jsonData = await responseMessage7.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.avgPriceForWeekly = values.avgPriceForWeekly;
                ViewBag.rnd7 = rnd7;
            }

            var responseMessage8 = await client.GetAsync("https://localhost:7214/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int rnd8 = rnd.Next(0, 101);
                var jsonData = await responseMessage8.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.avgPriceForMonthly = values.avgPriceForMonthly;
                ViewBag.rnd8 = rnd8;
            }

            var responseMessage9 = await client.GetAsync("https://localhost:7214/api/Statistics/GetCarCountByTranmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int rnd9 = rnd.Next(0, 101);
                var jsonData = await responseMessage9.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.carCountByTransmissionIsAutoCount = values.carCountByTransmissionIsAutoCount;
                ViewBag.rnd9 = rnd9;
            }

            var responseMessage10 = await client.GetAsync("https://localhost:7214/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int rnd10 = rnd.Next(0, 101);
                var jsonData = await responseMessage10.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.brandNameByMaxCar = values.brandName;
                ViewBag.rnd10 = rnd10;
            }

            var responseMessage11 = await client.GetAsync("https://localhost:7214/api/Statistics/GetBlogTitleMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int rnd11 = rnd.Next(0, 101);
                var jsonData = await responseMessage11.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.blogTitle = values.title;
                ViewBag.rnd11 = rnd11;
            }

            var responseMessage12 = await client.GetAsync("https://localhost:7214/api/Statistics/GetCarCountByKmSmallarThen1000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int rnd12 = rnd.Next(0, 101);
                var jsonData = await responseMessage12.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.carCountByKmSmallerThen1000 = values.carCountByKmSmallerThen1000;
                ViewBag.rnd12 = rnd12;
            }

            var responseMessage13 = await client.GetAsync("https://localhost:7214/api/Statistics/GetCarCountByFuelGasolineOrDisel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int rnd13 = rnd.Next(0, 101);
                var jsonData = await responseMessage13.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.carCountByFuelGosalineOrDiesel = values.carCountByFuelGosalineOrDiesel;
                ViewBag.rnd13 = rnd13;
            }

            var responseMessage14 = await client.GetAsync("https://localhost:7214/api/Statistics/GetCarCountFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int rnd14 = rnd.Next(0, 101);
                var jsonData = await responseMessage14.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.carCountByFuelElectric = values.carCountByFuelElectric;
                ViewBag.rnd14 = rnd14;
            }

            var responseMessage15 = await client.GetAsync("https://localhost:7214/api/Statistics/GetBrandAndModelByRentPriceDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int rnd15 = rnd.Next(0, 101);
                var jsonData = await responseMessage15.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.brandAndModelByRentPriceDailyMax = values.brandAndModelByRentPriceDailyMax;
                ViewBag.rnd15 = rnd15;
            }

            var responseMessage16 = await client.GetAsync("https://localhost:7214/api/Statistics/GetBrandAndModelByRentPriceDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int rnd16 = rnd.Next(0, 101);
                var jsonData = await responseMessage16.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.brandAndModelByRentPriceDailyMin = values.brandAndModelByRentPriceDailyMin;
                ViewBag.rnd16 = rnd16;
            }

            return View();
        }
    }
}
