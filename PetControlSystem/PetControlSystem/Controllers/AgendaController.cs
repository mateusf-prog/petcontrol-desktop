using Microsoft.AspNetCore.Mvc;
using PetControlSystem.Dto;
using PetControlSystem.Models;
using PetControlSystem.Services.Interfaces;

namespace PetControlSystem.Controllers
{
    [ApiController]
    [Route("api/schedules")]
    public class AgendaController : ControllerBase
    {
        private readonly IAgenda _agendaService;

        public AgendaController(IAgenda agendaService)
        {
            _agendaService = agendaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Agenda>> GetAll()
        {
            var schedules = _agendaService.ReadAll();
            return Ok(schedules);
        }

        [HttpGet("{id}")]
        public ActionResult<Agenda> GetById(long id)
        {
            var schedule = _agendaService.Read(id.ToString());
            if (schedule == null)
            {
                return NotFound();
            }
            return Ok(schedule);
        }

        [HttpPost]
        public ActionResult<Agenda> Create(AgendaDto agendaDto)
        {
            var result = _agendaService.Create(agendaDto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id}, result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _agendaService.Delete(id.ToString());
            return NoContent();
        }
    }
}
