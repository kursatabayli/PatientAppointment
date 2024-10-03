using MediatR;
using PatientAppointment.Application.CQRS.Queries.PolyclinicQueries;
using PatientAppointment.Application.CQRS.Results.PolyclinicResults;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PolyclinicHandlers
{
    public class GetPolyclinicQueryHandler : IRequestHandler<GetPolyclinicQuery, List<PolyclinicResult>>
    {
        private readonly IRepository<Polyclinic> _repository;

        public GetPolyclinicQueryHandler(IRepository<Polyclinic> repository)
        {
            _repository = repository;
        }

        public async Task<List<PolyclinicResult>> Handle(GetPolyclinicQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new PolyclinicResult
            {
                PolyclinicId = x.PolyclinicId,
                PolyclinicName = x.PolyclinicName
            }).ToList();
        }
    }
}
