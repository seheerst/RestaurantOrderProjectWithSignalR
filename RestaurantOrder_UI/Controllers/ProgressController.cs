using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.Controllers
{
    public class ProgressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
