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
    public class GetMedicationByIdQueryHandler : IRequestHandler<GetMedicationByIdQuery, MedicationResult>
    {
        private readonly IRepository<Medication> _repository;
        private readonly IMapper _mapper;

        public GetMedicationByIdQueryHandler(IRepository<Medication> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MedicationResult> Handle(GetMedicationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<MedicationResult>(value);
            return result;
        }
    }
}
