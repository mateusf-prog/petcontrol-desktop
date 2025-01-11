namespace PetControlSystem.Models
{
    public class Product
    {
        private Guid Id { get; set; }
        private string Name { get; set; }
        private decimal Price { get; set; }
        private string Description { get; set; }
        private int Stock { get; set; }
        private List<OrderItem> Items = new();

        public Product(Guid id, string name, decimal price, string description, int stock)
        {
            Id = id;
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