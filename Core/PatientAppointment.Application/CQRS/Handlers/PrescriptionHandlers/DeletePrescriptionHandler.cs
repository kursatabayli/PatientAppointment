using MediatR;
using PatientAppointment.Application.CQRS.Commands.PrescriptionCommands;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PrescriptionHandlers
{
    public class DeletePrescriptionHandler : IRequestHandler<DeletePrescriptionCommand>
    {
        private readonly IRepository<Prescription> _repository;

        public DeletePrescriptionHandler(IRepository<Prescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeletePrescriptionCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
