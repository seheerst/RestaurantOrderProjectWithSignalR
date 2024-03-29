﻿namespace RestaurantOrder_UI.Dtos.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactID { get; set; }
        public string ContactTitle { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string FooterDescription { get; set; }
        public string FooterTitle { get; set; }
        public string OpenDays { get; set; }
        public string OpenHours { get; set; }
        public string OpenDaysDescription { get; set; }
    }
}
