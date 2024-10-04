using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.LocationQueries;
using PatientAppointment.Application.CQRS.Results.LocationResults;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<LocationResult>>
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mapper;

        public GetLocationQueryHandler(IRepository<Location> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<LocationResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<LocationResult>>(values);
            return results;
        }
    }
}
