using MediatR;
using PatientAppointment.Application.CQRS.Results.ContactResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.ContactQueries
{
    public class GetContactQuery : IRequest<List<ContactResult>>
    {
    }
}
