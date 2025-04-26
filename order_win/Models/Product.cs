using System.Reflection;

namespace order_win.Models
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
            UID = string.Empty;
            Name = string.Empty;
        }
        public int Id { get; set; }
        public string UID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public required int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
