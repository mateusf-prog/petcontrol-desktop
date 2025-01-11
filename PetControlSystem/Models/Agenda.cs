namespace PetControlSystem.Models
{
    public class Agenda
    {
        public Guid Guid { get; private set; }
        public DateTime Date { get; private set; }
        public Customer? Customer { get; private set; }
        public List<Service>? Services { get; private set; }

        public Agenda() { }

        public Agenda(Guid guid, DateTime date, Customer customer, List<Service> services)
        {
            Guid = guid;
            Date = date;
            Customer = customer;
            Services = services;
        }
    }
}