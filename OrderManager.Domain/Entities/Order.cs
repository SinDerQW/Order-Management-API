using OrderManager.Domain.Enums;

namespace OrderManager.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }  
        public OrderStatus Status { get; set; } = OrderStatus.Created;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal Total => Items.Sum(i => i.Quantity * i.Product.Price);

    }
}
