using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRProjectWebUI.Dtos.CategoryDtos;
using System.Net.Http;

namespace SignalRProjectWebUI.ViewComponents.MenuComponents
{
    public class _MenuCategoryFilterComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _MenuCategoryFilterComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7108/api/Category");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
