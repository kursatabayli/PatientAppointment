using MediatR;
using PatientAppointment.Application.CQRS.Commands.MedicationCommands;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.MedicationHandlers
{
    public class DeleteMedicationHandler : IRequestHandler<DeleteMedicationCommand>
    {
        private readonly IRepository<Medication> _repository;

        public DeleteMedicationHandler(IRepository<Medication> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteMedicationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
