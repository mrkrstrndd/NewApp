namespace Backend.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime PlacedAt { get; set; } = DateTime.UtcNow;
        public decimal TotalPrice { get; set; }

        public User User { get; set; } = null!;
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
