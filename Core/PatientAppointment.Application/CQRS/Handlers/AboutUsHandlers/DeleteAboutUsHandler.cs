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
    public class DeleteAboutUsHandler : IRequestHandler<DeleteAboutUsCommand>
    {
        private readonly IRepository<AboutUs> _repository;

        public DeleteAboutUsHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteAboutUsCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
