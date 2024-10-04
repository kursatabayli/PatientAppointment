using AutoMapper;
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
        private readonly IMapper _mapper;

        public GetPolyclinicByIdQueryHandler(IRepository<Polyclinic> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PolyclinicResult> Handle(GetPolyclinicByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<PolyclinicResult>(value);
            return result;
        }
    }
}
