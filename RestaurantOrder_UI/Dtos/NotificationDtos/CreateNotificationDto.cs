﻿namespace RestaurantOrder_UI.Dtos.NotificationDtos
{
    public class CreateNotificationDto
    {
        public string Description { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
