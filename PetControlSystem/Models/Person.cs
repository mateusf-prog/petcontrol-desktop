
namespace PetControlSystem.Models
{
    public class Person
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string? Document { get; private set; }

        public Person(string name, string email, string phone, string document)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Document = document;
        }
    }
}
