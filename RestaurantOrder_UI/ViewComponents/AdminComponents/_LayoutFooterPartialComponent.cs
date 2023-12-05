using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.ViewComponents.AdminComponents
{
    public class _LayoutFooterPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
