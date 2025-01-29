using System.ComponentModel.DataAnnotations.Schema;

namespace PetControlSystem.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public int Stock { get; private set; }
        public ICollection<Order>? Orders { get; set; }

        public Product(string name, decimal price, string description, int stock)
        {
            Name = name;
            Price = price;
            Description = description;
            Stock = stock;
        }
    }
}