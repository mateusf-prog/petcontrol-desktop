using System.Xml.Linq;
using PetControlSystem.Models.Enum;

namespace PetControlSystem.Models
{
    public class Pet
    {
        public long Id { get; private set; }
        public string? Name { get; private set; }
        public long CustomerId { get; private set; }
        public Customer Customer { get; private set; }
        public AnimalType Type { get; private set; }

        public Pet() { }

        public Pet(string name, Customer customer, AnimalType type)
        {
            Name = name;
            Customer = customer;
            Type = type;
        }
    }
}