using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
