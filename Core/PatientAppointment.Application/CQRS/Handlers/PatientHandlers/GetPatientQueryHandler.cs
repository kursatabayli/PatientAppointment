using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.PatientQueries;
using PatientAppointment.Application.CQRS.Results.PatientResults;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PatientHandlers
{
    public class GetPatientQueryHandler : IRequestHandler<GetPatientQuery, List<PatientResult>>
    {
        private readonly IRepository<Patient> _repository;
        private readonly IMapper _mapper;

        public GetPatientQueryHandler(IRepository<Patient> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<PatientResult>> Handle(GetPatientQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<PatientResult>>(values);
            return results;
        }
    }
}
