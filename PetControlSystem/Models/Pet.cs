using System.Xml.Linq;
using PetControlSystem.Models.Enum;

namespace PetControlSystem.Models
{
    public class Pet
    {
        private readonly Guid Id;
        private readonly string? Name;
        private readonly AnimalType Type;

        public Pet() { }

        public Pet(Guid id, string name, AnimalType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}