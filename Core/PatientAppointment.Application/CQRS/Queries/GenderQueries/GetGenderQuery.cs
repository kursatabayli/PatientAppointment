using MediatR;
using PatientAppointment.Application.CQRS.Results.GenderResults;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.GenderQueries
{
    public class GetGenderQuery:IRequest<List<GenderResult>>
    {
    }
}
