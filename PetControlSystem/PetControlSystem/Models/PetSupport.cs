
using System.ComponentModel.DataAnnotations.Schema;

namespace PetControlSystem.Models
{
    public class PetSupport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; }
        public string? Name { get; private set; }
        public decimal SmallPrice { get; private set; }
        public decimal MediumPrice { get; private set; }
        public decimal LargePrice { get; private set; }
        public ICollection<Agenda> Appointments = [];
    }
}