using MediatR;
using PatientAppointment.Application.CQRS.Queries.AppointmentQueries;
using PatientAppointment.Application.CQRS.Results.AppointmentResults;
using PatientAppointment.Domain.Interfaces;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.AppointmentHandlers
{
    public class GetAppointmentByIdQueryHandler : IRequestHandler<AppointmentByIdQuery, AppointmentResult>
    {
        private readonly IRepository<Appointment> _repository;

        public GetAppointmentByIdQueryHandler(IRepository<Appointment> repository)
        {
            _repository = repository;
        }

        public async Task<AppointmentResult> Handle(AppointmentByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new AppointmentResult
            {
                AppointmentId = values.AppointmentId,
                AppointmentDate = values.AppointmentDate,
                AppointmentTime = values.AppointmentTime,
                PolyclinicId = values.PolyclinicId,
                PatientID = values.PatientID,
                PersonnelId = values.PersonnelId,
                StatusDescription = values.StatusDescription,
                StatusId = values.StatusId,
            };
        }
    }
}
