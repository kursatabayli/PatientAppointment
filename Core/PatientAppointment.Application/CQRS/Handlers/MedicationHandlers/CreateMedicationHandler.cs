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
    public class CreateMedicationHandler : IRequestHandler<CreateMedicationCommand>
    {
        private readonly IRepository<Medication> _repository;

        public CreateMedicationHandler(IRepository<Medication> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMedicationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Medication
            {
                Name = request.Name,
            });
        }
    }
}
