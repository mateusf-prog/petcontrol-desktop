namespace PetControlSystem.Models
{
    public class Customer : Person
    {
        public Guid Id;
        public List<Pet> Pets = new();
        public List<Agenda> Appointments = new();
        public List<Order> Orders = new();
    }
}