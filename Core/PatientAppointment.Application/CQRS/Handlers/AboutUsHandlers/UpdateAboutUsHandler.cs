using MediatR;
using PatientAppointment.Application.CQRS.Commands.AboutUsCommands;
using PatientAppointment.Domain.Interfaces;
using PatientAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.AboutUsHandlers
{
    public class UpdateAboutUsHandler : IRequestHandler<UpdateAboutUsCommand>
    {
        private readonly IRepository<AboutUs> _repository;

        public UpdateAboutUsHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutUsCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AboutUsId);
            values.Title = request.Title;
            values.Description = request.Description;
            values.ImageUrl = request.ImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
