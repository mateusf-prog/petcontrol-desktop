using PetControlSystem.Models;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace PetControlSystem.Models
{
    public class Order
    {
        public Guid Id { get; private set; }
        public DateTime Date { get; private set; }
        public Customer Customer { get; private set; }
        public List<OrderItem> Items = new();

        public Order() { }

        public Order(Guid id, Customer customer)
        {
            Id = id;
            Date = DateTime.Now;
            Customer = customer;
        }
    }
}