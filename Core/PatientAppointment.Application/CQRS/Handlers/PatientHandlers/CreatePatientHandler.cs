using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.PatientCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PatientHandlers
{
    public class CreatePatientHandler : IRequestHandler<CreatePatientCommand>
    {
        private readonly IRepository<Patient> _repository;
        private readonly IMapper _mapper;

        public CreatePatientHandler(IRepository<Patient> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Patient>(request);
            await _repository.CreateAsync(value);
        }
    }
}
