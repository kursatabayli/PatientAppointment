using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.MedicationCommands;
using PatientAppointment.Application.CQRS.Queries.MedicationQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MedicationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Medication()
        {
            var values = await _mediator.Send(new GetAllMedicationQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> MedicationById(int id)
        {
            var value = await _mediator.Send(new GetMedicationByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedication(CreateMedicationCommand command)
        {
            await _mediator.Send(command);
            return Ok("İlaç Bilgisi Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMedication(UpdateMedicationCommand command)
        {
            await _mediator.Send(command);
            return Ok("İlaç Bilgisi Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMedication(int id)
        {
            await _mediator.Send(new DeleteMedicationCommand(id));
            return Ok("İlaç Bilgisi Silindi");
        }
    }
}
