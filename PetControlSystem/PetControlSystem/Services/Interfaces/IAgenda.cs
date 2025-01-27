using PetControlSystem.Dto;

namespace PetControlSystem.Services.Interfaces
{
    public interface IAgenda
    {
        AgendaDto Create(AgendaDto input);
        void Delete(string id);
        AgendaDto Read(string id);
        List<AgendaDto> ReadAll();
    }
}
