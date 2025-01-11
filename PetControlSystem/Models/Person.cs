
namespace PetControlSystem.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Document { get; set; }
        public DateTime BirthDate { get; set; }

        public Person() { }

        public Person(string name, string email, string phone, string document, DateTime birthDate)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Document = document;
            BirthDate = birthDate;
        }
    }
}
