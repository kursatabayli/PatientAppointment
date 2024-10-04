using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.AppointmentStatusCommands;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.AppointmentStatusHandlers
{
    public class CreateAppointmentStatusHandler : IRequestHandler<CreateAppointmentStatusCommand>
    {
        private readonly IRepository<AppointmentStatus> _repository;
        private readonly IMapper _mapper;

        public CreateAppointmentStatusHandler(IRepository<AppointmentStatus> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAppointmentStatusCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<AppointmentStatus>(request);
            await _repository.CreateAsync(value);
        }
    }
}
