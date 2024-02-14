using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpGet]
        public IActionResult NotificationList() {
            var values = _notificationService.TGetAllList();
            return Ok(values);
        }

        [HttpGet("NotificationCountByStatusFalse")]

        public IActionResult NotificationCountByStatusFalse()
        {
            var count = _notificationService.TNotificationCountByStatusFalse();
            return Ok(count);
        }
    }
}
