using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.UserQueries;
using PatientAppointment.Application.CQRS.Results.UserResults;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.UserHandlers
{
    public class GetUserWithPatientDetailsHandler : IRequestHandler<GetUserWithPatientDetailsQuery, List<GetUserWithPatientDetailsResult>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserWithPatientDetailsHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetUserWithPatientDetailsResult>> Handle(GetUserWithPatientDetailsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetUserWithPatientDetails();
            var results = _mapper.Map<List<GetUserWithPatientDetailsResult>>(values);
            return results;
        }
    }
}
