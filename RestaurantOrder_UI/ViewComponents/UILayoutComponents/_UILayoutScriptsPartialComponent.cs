using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptsPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
