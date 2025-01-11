
namespace PetControlSystem.Models
{
    public class User
    {
        public long Id { get; private set; }
        public string? Name { get; private set; }
        public string? Password { get; private set; }

        public User() { }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
