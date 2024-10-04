using MediatR;
using PatientAppointment.Application.CQRS.Results.AppointmentStatusResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.AppointmentStatusQueries
{
    public class GetAppointmentStatusByIdQuery:IRequest<AppointmentStatusResult>
    {
        public int Id { get; set; }

        public GetAppointmentStatusByIdQuery(int id)
        {
            Id = id;
        }
    }
}
