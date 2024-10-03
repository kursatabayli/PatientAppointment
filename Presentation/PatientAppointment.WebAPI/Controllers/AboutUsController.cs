using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.AboutUsCommands;
using PatientAppointment.Application.CQRS.Queries.AboutUsQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutUsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AboutUS()
        {
            var values = await _mediator.Send(new AboutUsQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> AboutUsById(int id)
        {
            var value = await _mediator.Send(new AboutUsByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutUs(CreateAboutUsCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımızda Bilgisi Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAboutUs(UpdateAboutUsCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımızda Bilgisi Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAboutUs(int id)
        {
            await _mediator.Send(new DeleteAboutUsCommand(id));
            return Ok("Hakkımızda Bilgisi Silindi");
        }
    }
}
