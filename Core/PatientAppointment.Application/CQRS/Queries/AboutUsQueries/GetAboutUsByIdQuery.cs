using MediatR;
using PatientAppointment.Application.CQRS.Results.AboutUsResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.AboutUsQueries
{
    public class GetAboutUsByIdQuery : IRequest<AboutUsResult>
    {
        public int Id { get; set; }

        public GetAboutUsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
