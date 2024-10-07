using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.UserCommands;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.UserHandlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;

        public CreateUserHandler(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<User>(request);
            await _repository.CreateAsync(value);

        }
    }
}
