using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.GenderQueries;
using PatientAppointment.Application.CQRS.Results.GenderResults;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.GenderHandlers
{
    public class GetAllGenderQueryHandler : IRequestHandler<GetAllGenderQuery, List<GenderResult>>
    {
        private readonly IRepository<Gender> _repository;
        private readonly IMapper _mapper;

        public GetAllGenderQueryHandler(IRepository<Gender> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GenderResult>> Handle(GetAllGenderQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<GenderResult>>(values);
            return results;
        }
    }
}
