using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientUserCount()
        {
            return View();
        }
    }
}
