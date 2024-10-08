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
    public class GetUserWithPersonnelDetailsHandler : IRequestHandler<GetUserWithPersonnelDetailsQuery, List<GetUserWithPersonnelDetailsResult>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserWithPersonnelDetailsHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetUserWithPersonnelDetailsResult>> Handle(GetUserWithPersonnelDetailsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetUserWithPersonnelDetails();
            var results = _mapper.Map<List<GetUserWithPersonnelDetailsResult>>(values);
            return results;
        }
    }
}
