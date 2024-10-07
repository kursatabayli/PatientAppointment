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
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserResult>
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;

        public GetUserByIdQueryHandler(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UserResult> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<UserResult>(value);
            return result;
        }
    }
}
