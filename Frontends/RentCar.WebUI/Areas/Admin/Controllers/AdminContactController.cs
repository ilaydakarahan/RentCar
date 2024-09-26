using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.ContactDto;

namespace RentCar.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7214/api/Contacts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var content = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(content);
                return View(values);
            }
            return View();
        }
    }
}
