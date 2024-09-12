using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.BlogDto;

namespace RentCar.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title1 = "Bloglar";
            ViewBag.Title2 = "Yazarlarımızın Blogları";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7214/api/Blogs/GetAllBlogsWithAuthorList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var content = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(content);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> BlogDetail(string blogTitle, int id)
        {
            ViewBag.Title1 = "Bloglar > Blog Detayı";
            ViewBag.Title2 = "Blog Detayı Ve Yorumlar";
            ViewBag.blogTitle = blogTitle;
            ViewBag.blogid = id;
            return View();
        }
    }
}
