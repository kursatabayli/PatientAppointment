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
    public class GetPolyclinicByIdQueryHandler : IRequestHandler<GetPolyclinicByIdQuery, PolyclinicResult>
    {
        private readonly IRepository<Polyclinic> _repository;

        public GetPolyclinicByIdQueryHandler(IRepository<Polyclinic> repository)
        {
            _repository = repository;
        }

        public async Task<PolyclinicResult> Handle(GetPolyclinicByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new PolyclinicResult
            {
                PolyclinicId = value.PolyclinicId,
                PolyclinicName = value.PolyclinicName
            };
        }
    }
}
