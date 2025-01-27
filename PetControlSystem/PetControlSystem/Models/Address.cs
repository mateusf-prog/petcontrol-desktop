using System.ComponentModel.DataAnnotations.Schema;

namespace PetControlSystem.Models
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; }
        public string? ZipCode { get; private set; }
        public string? Street { get; private set; }
        public string? Number { get; private set; }
        public string? City { get; private set; }
        public string? District { get; private set; }
        public string? Uf { get; private set; }

        public Address() { }

        public Address(string zipCode, string street, string number, string city, string district, string uf)
        {
            ZipCode = zipCode;
            Street = street;
            Number = number;
            City = city;
            District = district;
            Uf = uf;
        }
    }
}