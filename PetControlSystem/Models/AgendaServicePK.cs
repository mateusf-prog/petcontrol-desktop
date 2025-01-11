namespace PetControlSystem.Models
{
    public class AgendaServicePK
    {
        public Agenda Appointment { get; set; }
        public Service Service { get; set; }

        public AgendaServicePK() { }
    }
}