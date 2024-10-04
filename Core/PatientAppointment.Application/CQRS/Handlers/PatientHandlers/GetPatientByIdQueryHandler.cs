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
    public class GetPatientByIdQueryHandler : IRequestHandler<GetPatientByIdQuery, PatientResult>
    {
        private readonly IRepository<Patient> _repository;
        private readonly IMapper _mapper;

        public GetPatientByIdQueryHandler(IRepository<Patient> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PatientResult> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<PatientResult>(value);
            return result;
        }
    }
}
