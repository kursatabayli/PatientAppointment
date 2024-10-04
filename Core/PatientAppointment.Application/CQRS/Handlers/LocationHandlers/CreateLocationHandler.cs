using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.LocationCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.LocationHandlers
{
    internal class CreateLocationHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mapper;

        public CreateLocationHandler(IRepository<Location> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Location>(request);
            await _repository.CreateAsync(value);
        }
    }
}
