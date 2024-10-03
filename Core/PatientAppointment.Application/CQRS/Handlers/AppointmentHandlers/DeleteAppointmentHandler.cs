using MediatR;
using PatientAppointment.Application.CQRS.Commands.AppointmentCommands;
using PatientAppointment.Domain.Interfaces;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.AppointmentHandlers
{
    public class DeleteAppointmentHandler : IRequestHandler<DeleteAppointmentCommand>
    {
        private readonly IRepository<Appointment> _repository;

        public DeleteAppointmentHandler(IRepository<Appointment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteAppointmentCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
