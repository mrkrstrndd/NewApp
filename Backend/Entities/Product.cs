using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; } = null!;

        [MaxLength(150)]
        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
