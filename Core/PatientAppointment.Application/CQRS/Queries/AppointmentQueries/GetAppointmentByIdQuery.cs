using MediatR;
using PatientAppointment.Application.CQRS.Results.AppointmentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.AppointmentQueries
{
    public class GetAppointmentByIdQuery : IRequest<AppointmentResult>
    {
        public int Id { get; set; }

        public GetAppointmentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
