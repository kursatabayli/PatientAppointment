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
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, LocationResult>
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mapper;

        public GetLocationByIdQueryHandler(IRepository<Location> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<LocationResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<LocationResult>(value);
            return result;
        }
    }
}
