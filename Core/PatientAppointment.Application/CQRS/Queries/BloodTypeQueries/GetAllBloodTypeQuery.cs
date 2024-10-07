using MediatR;
using PatientAppointment.Application.CQRS.Results.BloodTypeResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.BloodTypeQueries
{
    public class GetAllBloodTypeQuery:IRequest<List<BloodTypeResult>>
    {
    }
}
