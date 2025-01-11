namespace PetControlSystem.Models
{
    public class Customer : Person
    {
        public long Id { get; private set; }

        public List<Pet> Pets = [];
        public List<Agenda> Appointments = [];
        public List<Order> Orders = [];

        public Customer() { }

        public Customer(string name, string email, string phone, string document)
            : base(name, email, phone, document) { }
    }
}