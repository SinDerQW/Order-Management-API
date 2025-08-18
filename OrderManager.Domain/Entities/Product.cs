﻿namespace  OrderManager.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
         
    }
}
