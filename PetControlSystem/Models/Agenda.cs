namespace PetControlSystem.Models
{
    public class Agenda
    {
        public long Id { get; private set; }
        public DateTime Date { get; private set; }
        public Customer? Customer { get; private set; }
        public List<AgendaService> Services = [];

        public Agenda() { }

        public Agenda(DateTime date, Customer customer, List<AgendaService> services)
        {
            Date = date;
            Customer = customer;
            Services = services;
        }
    }
}