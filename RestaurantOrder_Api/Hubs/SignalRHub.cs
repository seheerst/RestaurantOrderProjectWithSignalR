using Microsoft.AspNetCore.SignalR;
using RestaurantOrderProject.DataAccessLayer.Concrete;

namespace RestaurantOrder_Api.Hubs
{
    public class SignalRHub : Hub
    {
        RestaurantOrderContext context = new RestaurantOrderContext();

        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
