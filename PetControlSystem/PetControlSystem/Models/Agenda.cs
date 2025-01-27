using System.ComponentModel.DataAnnotations.Schema;

namespace PetControlSystem.Models
{
    public class Agenda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; }
        public DateTime Date { get; private set; }
        public long CustomerId { get; private set; }
        public Customer Customer { get; private set; }
        public ICollection<PetSupport> Services = [];

        public Agenda() { }

        public Agenda(DateTime date, Customer customer, ICollection<PetSupport> services)
        {
            Date = date;
            Customer = customer;
            Services = services;
        }
    }
}