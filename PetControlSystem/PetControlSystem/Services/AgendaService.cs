using PetControlSystem.Dto;
using PetControlSystem.Mappers;
using PetControlSystem.Repositories.Interfaces;
using PetControlSystem.Services.Interfaces;

namespace PetControlSystem.Services
{
    public class AgendaService : IAgenda
    {
        private readonly IRepository _repository;

        public AgendaService(IRepository repository)
        {
            _repository = repository;
        }

        public AgendaDto Create(AgendaDto input)
        {
            var agenda = input.ToModel();
            _repository.Agendas.Add(agenda);
            _repository.SaveChanges();
            return input;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public AgendaDto Read(string id)
        {
            throw new NotImplementedException();
        }

        public List<AgendaDto> ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}
