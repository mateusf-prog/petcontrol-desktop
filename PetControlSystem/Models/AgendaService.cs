namespace PetControlSystem.Models
{
    public class AgendaService
    {
        public AgendaServicePK id;

        public AgendaService(Agenda appointment, Service service)
        {
            id.Service = service;
            id.Appointment = appointment;
        }

        public Service GetService()
        {
            return id.Service;
        }

        public void SetService(Service service)
        {
            id.Service = service;
        }

        public Agenda GetAppointment()
        {
            return id.Appointment;
        }

        public void SetAppointment(Agenda appointment)
        {
            id.Appointment = appointment;
        }
    }
}
