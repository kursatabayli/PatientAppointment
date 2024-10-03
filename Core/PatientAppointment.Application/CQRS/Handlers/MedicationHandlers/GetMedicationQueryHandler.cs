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
    public class GetMedicationQueryHandler : IRequestHandler<GetMedicationQuery, List<MedicationResult>>
    {
        private readonly IRepository<Medication> _repository;

        public GetMedicationQueryHandler(IRepository<Medication> repository)
        {
            _repository = repository;
        }

        public async Task<List<MedicationResult>> Handle(GetMedicationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new MedicationResult
            {
                MedicationId = x.MedicationId,
                Name = x.Name
            }).ToList();
        }
    }
}
