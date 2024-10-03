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
    public class UpdateMedicationHandler:IRequestHandler<UpdateMedicationCommand>
    {
        private readonly IRepository<Medication> _repository;

        public UpdateMedicationHandler(IRepository<Medication> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMedicationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.MedicationId);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
