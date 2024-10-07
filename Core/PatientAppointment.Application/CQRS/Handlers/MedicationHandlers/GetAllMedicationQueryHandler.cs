using AutoMapper;
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
    public class GetAllMedicationQueryHandler : IRequestHandler<GetAllMedicationQuery, List<MedicationResult>>
    {
        private readonly IRepository<Medication> _repository;
        private readonly IMapper _mapper;

        public GetAllMedicationQueryHandler(IRepository<Medication> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<MedicationResult>> Handle(GetAllMedicationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<MedicationResult>>(values);
            return results;
        }
    }
}
