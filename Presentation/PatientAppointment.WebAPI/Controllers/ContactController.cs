using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.ContactCommands;
using PatientAppointment.Application.CQRS.Queries.ContactQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            var values = await _mediator.Send(new GetAllContactQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ContactById(int id)
        {
            var value = await _mediator.Send(new GetContactByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _mediator.Send(new DeleteContactCommand(id));
            return Ok("İletişim Bilgisi Silindi");
        }
    }
}
