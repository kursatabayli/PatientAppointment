using MediatR;
using PatientAppointment.Application.CQRS.Results.PrescriptionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.PrescriptionQueries
{
    public class GetAllPrescriptionQuery : IRequest<List<PrescriptionResult>>
    {
    }
}
