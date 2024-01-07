using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.ViewComponents.UILayoutComponents
{
    public class _UILayoutFooterPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
