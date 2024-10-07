using MediatR;
using PatientAppointment.Application.CQRS.Commands.PatientCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PatientHandlers
{
    public class DeletePatientHandler : IRequestHandler<DeletePatientCommand>
    {
        private readonly IRepository<Patient> _repository;

        public DeletePatientHandler(IRepository<Patient> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
