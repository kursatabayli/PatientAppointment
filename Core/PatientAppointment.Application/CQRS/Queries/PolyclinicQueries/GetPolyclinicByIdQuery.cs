using MediatR;
using PatientAppointment.Application.CQRS.Results.PolyclinicResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.PolyclinicQueries
{
    public class GetPolyclinicByIdQuery : IRequest<PolyclinicResult>
    {
        public int Id { get; set; }

        public GetPolyclinicByIdQuery(int id)
        {
            Id = id;
        }
    }
}
