using MediatR;
using PatientAppointment.Application.CQRS.Queries.MedicationQueries;
using PatientAppointment.Application.CQRS.Results.MedicationResults;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.MedicationHandlers
{
    public class GetMedicationByIdQueryHandler : IRequestHandler<GetMedicationByIdQuery, MedicationResult>
    {
        private readonly IRepository<Medication> _repository;

        public GetMedicationByIdQueryHandler(IRepository<Medication> repository)
        {
            _repository = repository;
        }

        public async Task<MedicationResult> Handle(GetMedicationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new MedicationResult
            {
                MedicationId = value.MedicationId,
                Name = value.Name
            };
        }
    }
}
