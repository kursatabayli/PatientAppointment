using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.BloodTypeQueries;
using PatientAppointment.Application.CQRS.Results.BloodTypeResults;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.BloodTypeHandlers
{
    public class GetBloodTypeQueryHandler : IRequestHandler<BloodTypeQuery, List<BloodTypeResult>>
    {
        private readonly IRepository<BloodType> _repository;
        private readonly IMapper _mapper;

        public GetBloodTypeQueryHandler(IRepository<BloodType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<BloodTypeResult>> Handle(BloodTypeQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<BloodTypeResult>>(values);
            return results;
        }
    }
}
