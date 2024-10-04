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
    public class DeleteAppointmentStatusHandler : IRequestHandler<DeleteAppointmentStatusCommand>
    {
        private readonly IRepository<AppointmentStatus> _repository;

        public DeleteAppointmentStatusHandler(IRepository<AppointmentStatus> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteAppointmentStatusCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
