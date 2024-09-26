using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.FooterAddressDto;
using System.Text;

namespace RentCar.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AdminFooterAddressController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminFooterAddressController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7214/api/FooterAddresses");
            if (responseMessage.IsSuccessStatusCode)
            {
                var content = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(content);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateFooterAddress()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressDto createFooterAddressDto)
        {
            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(createFooterAddressDto);
            StringContent str = new StringContent(data, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7214/api/FooterAddresses", str);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateFooterAddress(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7214/api/FooterAddresses/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var content = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFooterAddressDto>(content);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressDto updateFooterAddressDto)
        {
            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(updateFooterAddressDto);
            StringContent str = new StringContent(data, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7214/api/FooterAddresses", str);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFooterAddress", new { area = "Admin" });
            }
            return View();
        }

        public async Task<IActionResult> RemoveFooterAddress(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7214/api/FooterAddresses/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFooterAddress", new { area = "Admin" });
            }
            return View();
        }
    }
}
