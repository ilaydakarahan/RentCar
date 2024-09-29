using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.StatisticDto;

namespace RentCar.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
        {
			var client = _httpClientFactory.CreateClient();

			var responseMessage = await client.GetAsync("https://localhost:7214/api/Statistics/GetCarCount");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
				ViewBag.carCount = values.carCount;
			}

			var responseMessage2 = await client.GetAsync("https://localhost:7214/api/Statistics/GetLocationCount");
			if (responseMessage2.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage2.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
				ViewBag.locationCount = values.locationCount;
			}

			var responseMessage5 = await client.GetAsync("https://localhost:7214/api/Statistics/GetBrandCount");
			if (responseMessage5.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage5.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
				ViewBag.brandCount = values.brandCount;
			}
			var responseMessage14 = await client.GetAsync("https://localhost:7214/api/Statistics/GetCarCountFuelElectric");
			if (responseMessage14.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage14.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
				ViewBag.carCountByFuelElectric = values.carCountByFuelElectric;
			}
			return View();
        }
    }
}
