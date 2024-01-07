using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.ViewComponents.UILayoutComponents
{
    public class _UILayoutNavbarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
