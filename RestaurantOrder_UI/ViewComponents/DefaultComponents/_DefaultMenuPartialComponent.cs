using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestaurantOrder_UI.Dtos.ProductDtos;

namespace RestaurantOrder_UI.ViewComponents.DefaultComponents
{
    public class _DefaultMenuPartialComponent: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultMenuPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7050/api/Product");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
