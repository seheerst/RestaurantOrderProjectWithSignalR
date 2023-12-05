using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
