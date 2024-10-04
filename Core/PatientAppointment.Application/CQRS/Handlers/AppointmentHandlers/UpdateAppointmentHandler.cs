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
    public class UpdateAppointmentHandler : IRequestHandler<UpdateAppointmentCommand>
    {
        private readonly IRepository<Appointment> _repository;
        private readonly IMapper _mapper;

        public UpdateAppointmentHandler(IRepository<Appointment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AppointmentId);
            _mapper.Map(request, values);
            await _repository.UpdateAsync(values);
        }
    }
}
