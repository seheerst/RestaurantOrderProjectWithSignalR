using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_UI.Dtos.BasketDtos
{
    public class ResultBasketDto
    {
        public int BasketID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int TableID { get; set; }
        public Table Table { get; set; }
    }
}
