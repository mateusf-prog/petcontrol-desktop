namespace PetControlSystem.Models
{
    public class Agenda
    {
        public long Guid { get; private set; }
        public DateTime Date { get; private set; }
        public Customer? Customer { get; private set; }
        public List<Service>? Services { get; private set; }

        public Agenda() { }

        public Agenda(DateTime date, Customer customer, List<Service> services)
        {
            Date = date;
            Customer = customer;
            Services = services;
        }
    }
}