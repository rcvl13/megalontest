namespace CustomerOrders.App.DTOs
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
    }
}