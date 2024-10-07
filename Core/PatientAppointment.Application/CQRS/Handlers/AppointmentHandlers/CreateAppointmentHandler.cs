using MediatR;
using PatientAppointment.Application.CQRS.Commands.AppointmentCommands;
using PatientAppointment.Domain.Interfaces;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PatientAppointment.Application.CQRS.Handlers.AppointmentHandlers
{
    public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand>
    {
        private readonly IRepository<Appointment> _repository;
        private readonly IMapper _mapper;

        public CreateAppointmentHandler(IRepository<Appointment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Appointment>(request);
            await _repository.CreateAsync(value);
        }
    }
}
