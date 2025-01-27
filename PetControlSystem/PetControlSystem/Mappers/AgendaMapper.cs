using PetControlSystem.Dto;
using PetControlSystem.Models;

namespace PetControlSystem.Mappers
{
    public static class AgendaMapper
    {
        public static AgendaDto ToDto(this Agenda agenda)
        {
            return new AgendaDto(agenda.Id, agenda.Date, agenda.Customer, agenda.Services);
        }

        public static Agenda ToModel(this AgendaDto dto)
        {
            return new Agenda(dto.Date, dto.Customer, dto.Services);
        }
    }
}
