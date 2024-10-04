using MediatR;
using PatientAppointment.Application.CQRS.Results.PersonnelResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.PersonnelQueries
{
    public class GetPersonnelByIdQuery : IRequest<PersonnelResult>
    {
        public int Id { get; set; }

        public GetPersonnelByIdQuery(int id)
        {
            Id = id;
        }
    }
}
