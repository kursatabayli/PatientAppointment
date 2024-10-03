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
    public class UpdateAppointmentHandler : IRequestHandler<UpdateAppointmentCommand>
    {
        private readonly IRepository<Appointment> _repository;

        public UpdateAppointmentHandler(IRepository<Appointment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AppointmentId);
            values.AppointmentDate = request.AppointmentDate;
            values.AppointmentTime = request.AppointmentTime;
            values.PolyclinicId = request.PolyclinicId;
            values.PatientID = request.PatientID;
            values.PersonnelId = request.PersonnelId;
            values.StatusId = request.PersonnelId;
            values.StatusDescription = request.StatusDescription;
            await _repository.UpdateAsync(values);
        }
    }
}
