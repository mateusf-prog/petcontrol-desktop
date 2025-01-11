namespace PetControlSystem.Models
{
    public class Product
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public int Stock { get; private set; }
        public List<OrderItem> Items = [];

        public Product(string name, decimal price, string description, int stock)
        {
            Name = name;
            Price = price;
            Description = description;
            Stock = stock;
        }

        public List<Order> GetOrders()
        {
            return Items.Select(item => item.GetOrder()).ToList();
        }
    }
}