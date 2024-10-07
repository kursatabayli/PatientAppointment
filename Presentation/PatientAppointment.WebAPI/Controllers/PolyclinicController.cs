using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.PolyclinicCommands;
using PatientAppointment.Application.CQRS.Queries.PolyclinicQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolyclinicController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PolyclinicController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Polyclinic()
        {
            var values = await _mediator.Send(new GetAllPolyclinicQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> PolyclinicById(int id)
        {
            var value = await _mediator.Send(new GetPolyclinicByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePolyclinic(CreatePolyclinicCommand command)
        {
            await _mediator.Send(command);
            return Ok("Poliklinik Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePolyclinic(UpdatePolyclinicCommand command)
        {
            await _mediator.Send(command);
            return Ok("Poliklinik Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePolyclinic(int id)
        {
            await _mediator.Send(new DeletePolyclinicCommand(id));
            return Ok("Poliklinik Silindi");
        }
    }
}
