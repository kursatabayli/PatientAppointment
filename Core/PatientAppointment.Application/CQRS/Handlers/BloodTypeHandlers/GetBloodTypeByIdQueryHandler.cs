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
    public class GetBloodTypeByIdQueryHandler : IRequestHandler<GetBloodTypeByIdQuery, BloodTypeResult>
    {
        private readonly IRepository<BloodType> _repository;
        private readonly IMapper _mapper;

        public GetBloodTypeByIdQueryHandler(IRepository<BloodType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BloodTypeResult> Handle(GetBloodTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<BloodTypeResult>(value);
            return result;
        }
    }
}
