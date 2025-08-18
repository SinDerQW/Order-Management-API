namespace OrderManagementAPI.OrderManager.Domain.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stok { get; set; }
         
        public Product(string name, string description, int price, int stok)
        {
            Random random = new Random();
            Id = $"{random.Next(0, 1000000)}{random.Next(0, 1000000)}";
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Stok = stok;


        }
    }
}
