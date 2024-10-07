using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.AppointmentStatusCommands;
using PatientAppointment.Application.CQRS.Queries.AppointmentStatusQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentStatusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppointmentStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AppointmentStatus()
        {
            var values = await _mediator.Send(new GetAllAppointmentStatusQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> AppointmentStatusById(int id)
        {
            var value = await _mediator.Send(new GetAppointmentStatusByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointmentStatus(CreateAppointmentStatusCommand command)
        {
            await _mediator.Send(command);
            return Ok("Randevu Durumu Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAppointmentStatus(UpdateAppointmentStatusCommand command)
        {
            await _mediator.Send(command);
            return Ok("Randevu Durumu Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAppointmentStatus(int id)
        {
            await _mediator.Send(new DeleteAppointmentStatusCommand(id));
            return Ok("Randevu Durumu Silindi");
        }
    }
}
