using MediatR;
using PatientAppointment.Application.CQRS.Results.PrescriptionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.PrescriptionQueries
{
    public class GetPrescriptionByIdQuery:IRequest<PrescriptionResult>
    {
        public int Id { get; set; }

        public GetPrescriptionByIdQuery(int id)
        {
            Id = id;
        }
    }
}
