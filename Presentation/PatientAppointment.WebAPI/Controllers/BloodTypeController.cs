using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAppointment.Application.CQRS.Commands.BloodTypeCommands;
using PatientAppointment.Application.CQRS.Queries.BloodTypeQueries;

namespace PatientAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BloodTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BloodTypes()
        {
            var values = await _mediator.Send(new GetAllBloodTypeQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BloodTypeById(int id)
        {
            var value = await _mediator.Send(new GetBloodTypeByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBloodType(CreateBloodTypeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kan Grubu Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBloodType(UpdateBloodTypeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kan Grubu Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBloodType(int id)
        {
            await _mediator.Send(new DeleteBloodTypeCommand(id));
            return Ok("Kan Grubu Silindi");
        }
    }
}
