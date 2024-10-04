using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.MedicationCommands;
using PatientAppointment.Application.CQRS.Commands.MessageCommands;
using PatientAppointment.Application.CQRS.Queries.MessageQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Message()
        {
            var values = await _mediator.Send(new GetMessageQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> MessageById(int id)
        {
            var value = await _mediator.Send(new GetMessageByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Mesaj Gönderildi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateMessageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Mesaj Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _mediator.Send(new DeleteMessageCommand(id));
            return Ok("Mesaj Silindi");
        }

    }
}
