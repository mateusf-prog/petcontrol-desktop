namespace PetControlSystem.Models
{
    public class Service
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal SmallPrice { get; private set; }
        public decimal MediumPrice { get; private set; }
        public decimal LargePrice { get; private set; }
        public List<AgendaService> items = [];

        public List<Agenda> GetAppointments()
        {
            return items.Select(item => item.GetAppointment()).ToList();
        }
    }
}