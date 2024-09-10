using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.ContactDto;
using System.Text;

namespace RentCar.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title1 = "İletişim";
            ViewBag.Title2 = "Bize Ulaşın";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            var client = _httpClientFactory.CreateClient();
            createContactDto.SendDate = DateTime.Now;
            var jsonData = JsonConvert.SerializeObject(createContactDto);   //Metin türünde gönderdiğim datayı json türüne dönüştürüp api üzerinden işlem yapar.
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json"); 

            //benim türkçe metinimi çevirirken sorun çıkmasın alıp kabul etmesi için encoding.utf8 yazılır.
            // applicartion/json= medya türü. Json formatında gönderme
            //Veri listelemede getAsync, veri kaydetmede PostAsync metodu kullanılır.

            var responseMessage = await client.PostAsync("https://localhost:7214/api/Contacts", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
