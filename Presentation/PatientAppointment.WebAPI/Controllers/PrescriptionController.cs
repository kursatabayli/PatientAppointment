using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.PrescriptionCommands;
using PatientAppointment.Application.CQRS.Queries.PrescriptionQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PrescriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Prescription()
        {
            var values = await _mediator.Send(new GetAllPrescriptionQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> PrescriptionById(int id)
        {
            var value = await _mediator.Send(new GetPrescriptionByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePrescription(CreatePrescriptionCommand command)
        {
            await _mediator.Send(command);
            return Ok("Reçete Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePrescription(UpdatePrescriptionCommand command)
        {
            await _mediator.Send(command);
            return Ok("Reçete Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePrescription(int id)
        {
            await _mediator.Send(new DeletePrescriptionCommand(id));
            return Ok("Reçete Silindi");
        }
    }
}
