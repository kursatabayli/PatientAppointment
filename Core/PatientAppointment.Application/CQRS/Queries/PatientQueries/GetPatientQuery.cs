using MediatR;
using PatientAppointment.Application.CQRS.Results.PatientResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.PatientQueries
{
    public class GetPatientQuery:IRequest<List<PatientResult>>
    {
    }
}
