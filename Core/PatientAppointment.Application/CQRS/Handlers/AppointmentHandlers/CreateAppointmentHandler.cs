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
    public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand>
    {
        private readonly IRepository<Appointment> _repository;

        public CreateAppointmentHandler(IRepository<Appointment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Appointment
            {
                AppointmentDate = request.AppointmentDate,
                AppointmentTime = request.AppointmentTime,
                PolyclinicId = request.PolyclinicId,
                PatientID = request.PatientID,
                PersonnelId = request.PersonnelId,
                StatusId = request.StatusId,
                StatusDescription = request.StatusDescription
            });
        }
    }
}
