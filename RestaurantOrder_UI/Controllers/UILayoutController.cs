using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
