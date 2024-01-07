using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeadPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
