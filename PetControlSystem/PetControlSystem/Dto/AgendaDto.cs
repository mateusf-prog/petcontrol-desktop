using PetControlSystem.Models;

namespace PetControlSystem.Dto
{
    public record AgendaDto(
        long Id,
        DateTime Date,
        Customer Customer,
        ICollection<PetSupport> Services
);
}
