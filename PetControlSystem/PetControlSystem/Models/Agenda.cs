namespace PetControlSystem.Models
{
    public class Agenda
    {
        public long Id { get; private set; }
        public DateTime Date { get; private set; }
        public long CustomerId { get; private set; }
        public Customer Customer { get; private set; }
        public ICollection<PetSupport> Services = [];
    }
}