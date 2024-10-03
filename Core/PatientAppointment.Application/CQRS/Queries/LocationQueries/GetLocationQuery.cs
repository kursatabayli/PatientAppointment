using MediatR;
using PatientAppointment.Application.CQRS.Results.LocationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.LocationQueries
{
    public class GetLocationQuery:IRequest<List<LocationResult>>
    {
    }
}
