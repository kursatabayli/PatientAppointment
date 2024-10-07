using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.PatientCommands;
using PatientAppointment.Application.CQRS.Queries.PatientQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PatientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Patient()
        {
            var values = await _mediator.Send(new GetAllPatientQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> PatientById(int id)
        {
            var value = await _mediator.Send(new GetPatientByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient(CreatePatientCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hasta Profili Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePatient(UpdatePatientCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hasta Bilgisi Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePatient(int id)
        {
            await _mediator.Send(new DeletePatientCommand(id));
            return Ok("Hasta Kayıtlardan Silindi");
        }
    }
}
