namespace order_win.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public decimal TotalPrice { get; set; }

        public List<OrderProduct>? OrderProducts { get; set; }
    }
}
