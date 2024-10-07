using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.AppointmentCommands;
using PatientAppointment.Application.CQRS.Queries.AppointmentQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppointmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Appointments()
        {
            var values = await _mediator.Send(new GetAllAppointmentQuery());
            return Ok(values);
        }        
        
        [HttpGet("{id}")]
        public async Task<IActionResult> AppointmentById(int id)
        {
            var value = await _mediator.Send(new GetAppointmentByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Randevu Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAppointment(UpdateAppointmentCommand command) 
        { 
            await _mediator.Send(command);
            return Ok("Randevu Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            await _mediator.Send(new DeleteAppointmentCommand(id));
            return Ok("Randevu Silindi");
        }

    }
}
