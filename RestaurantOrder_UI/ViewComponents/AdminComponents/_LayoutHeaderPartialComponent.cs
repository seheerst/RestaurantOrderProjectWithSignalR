using Microsoft.AspNetCore.Mvc;

namespace RestaurantOrder_UI.ViewComponents.AdminComponents
{
    public class _LayoutHeaderPartialComponent: ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
