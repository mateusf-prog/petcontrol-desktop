namespace PetControlSystem.Models
{
    public class AgendaService
    {
        public AgendaServicePK Id { get; set; } = new();

        public AgendaService(Agenda appointment, Service service)
        {
            Id.Appointment = appointment;
            Id.Service = service;
        }

        public Service GetService()
        {
            return Id.Service;
        }

        public void SetService(Service service)
        {
            Id.Service = service;
        }

        public Agenda GetAppointment()
        {
            return Id.Appointment;
        }

        public void SetAppointment(Agenda appointment)
        {
            Id.Appointment = appointment;
        }
    }
}
