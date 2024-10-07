using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.UserQueries;
using PatientAppointment.Application.CQRS.Results.UserResults;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.UserHandlers
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<UserResult>>
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;

        public GetAllUserQueryHandler(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UserResult>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<UserResult>>(values);
            return results;
        }
    }
}
