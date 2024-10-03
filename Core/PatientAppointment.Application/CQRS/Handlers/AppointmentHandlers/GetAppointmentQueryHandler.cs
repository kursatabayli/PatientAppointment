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
    public class GetAppointmentQueryHandler : IRequestHandler<AppointmentQuery, List<AppointmentResult>>
    {
        private readonly IRepository<Appointment> _repository;

        public GetAppointmentQueryHandler(IRepository<Appointment> repository)
        {
            _repository = repository;
        }

        public async Task<List<AppointmentResult>> Handle(AppointmentQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new AppointmentResult
            {
                AppointmentId = x.AppointmentId,
                AppointmentDate = x.AppointmentDate,
                AppointmentTime = x.AppointmentTime,
                PolyclinicId = x.PolyclinicId,
                PatientID = x.PatientID,
                PersonnelId = x.PersonnelId,
                StatusId = x.StatusId,
                StatusDescription = x.StatusDescription,
            }).ToList();
        }
    }
}
