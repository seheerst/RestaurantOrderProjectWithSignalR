using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.ViewComponents.DefaultComponents
{
    public class _DefaultMenuPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
