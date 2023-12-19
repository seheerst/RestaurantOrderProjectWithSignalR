using Microsoft.AspNetCore.SignalR;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;

namespace RestaurantOrder_Api.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public SignalRHub(ICategoryService categoryService, IProductService productService)
		{
			_categoryService = categoryService;
			_productService = productService;
		}

		public async Task SendStatistics()
        {
            var value1 = _categoryService.TGetCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value1);

			var value2 = _productService.TGetProductCount();
			await Clients.All.SendAsync("ReceiveProductCount", value2);

			var value3 = _categoryService.TActiveCategoryCount();
			await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

			var value4 = _categoryService.TPassiveCategoryCount();
			await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

			var value5 = _productService.TProductCountByCategoryNameHamburger();
			await Clients.All.SendAsync("ReceiveProductCountByHamburger", value5);

			var value6 = _productService.TProductCountByCategoryNameDrink();
			await Clients.All.SendAsync("ReceiveProductCountByDrink", value6);

		}


	}
}
