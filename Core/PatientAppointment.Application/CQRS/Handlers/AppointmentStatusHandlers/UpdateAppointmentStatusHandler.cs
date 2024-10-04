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
    public class UpdateAppointmentStatusHandler : IRequestHandler<UpdateAppointmentStatusCommand>
    {
        private readonly IRepository<AppointmentStatus> _repository;
        private readonly IMapper _mapper;

        public UpdateAppointmentStatusHandler(IRepository<AppointmentStatus> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAppointmentStatusCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.AppointmentStatusId);
            _mapper.Map(request, value);
            await _repository.UpdateAsync(value);
        }
    }
}
