using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.PersonnelCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PersonnelHandlers
{
    public class CreatePersonnelHandler : IRequestHandler<CreatePersonnelCommand>
    {
        private readonly IRepository<Personnel> _repository;
        private readonly IMapper _mapper;

        public CreatePersonnelHandler(IRepository<Personnel> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreatePersonnelCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Personnel>(request);
            await _repository.CreateAsync(value);
        }
    }
}
