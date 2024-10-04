using MediatR;
using PatientAppointment.Application.CQRS.Results.MessageResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.MessageQueries
{
    public class GetMessageQuery:IRequest<List<MessageResult>>
    {
    }
}
