﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentCar.Dto.CommentDto;

namespace RentCar.WebUI.ViewComponents.CommentViewComponents
{
    public class _CommentListByBlogComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _CommentListByBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7214/api/Comments/CommentListByBlog/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var content = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(content);
                if (values != null)
                {
                    return View(values);
                }
                else
                {
                    return View("Default", "Index");
                }

            }
            return View();
        }
    }
}
