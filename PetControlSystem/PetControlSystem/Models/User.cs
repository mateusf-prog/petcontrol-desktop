
namespace PetControlSystem.Models
{
    public class User : Person
    {
        public long Id { get; private set; }
        public string? Password { get; private set; }
        public Address Address { get; private set; }

        public User(string name, string email, string phone, string document) : base(name, email, phone, document)
        {
        }
    }
}
