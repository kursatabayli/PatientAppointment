using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.PersonnelCommands;
using PatientAppointment.Application.CQRS.Queries.PersonnelQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonnelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Personnel()
        {
            var values = await _mediator.Send(new GetAllPersonnelQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> PersonnelById(int id)
        {
            var value = await _mediator.Send(new GetPersonnelByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersonnel(CreatePersonnelCommand command)
        {
            await _mediator.Send(command);
            return Ok("Personel Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePersonnel(UpdatePersonnelCommand command)
        {
            await _mediator.Send(command);
            return Ok("Personel Bilgisi Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePersonnel(int id)
        {
            await _mediator.Send(new DeletePersonnelCommand(id));
            return Ok("Personel Silindi");
        }
    }
}
