using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.BlogDto;

namespace RentCar.WebUI.ViewComponents.BlogViewComponents
{
    public class _GetLast3BlogsWithAutorListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetLast3BlogsWithAutorListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7214/api/Blogs/GetLast3BlogsWithAuthorsList");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast3BlogsWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
