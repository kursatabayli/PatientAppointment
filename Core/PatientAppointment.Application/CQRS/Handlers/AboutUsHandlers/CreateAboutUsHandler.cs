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
    public class CreateAboutUsHandler : IRequestHandler<CreateAboutUsCommand>
    {
        private readonly IRepository<AboutUs> _repository;

        public CreateAboutUsHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutUsCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AboutUs
            {
                Title = request.Title,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
            });
        }
    }
}
