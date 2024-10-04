using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.PersonnelQueries;
using PatientAppointment.Application.CQRS.Results.PersonnelResults;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PersonnelHandlers
{
    public class GetPersonnelQueryHandler : IRequestHandler<GetPersonnelQuery, List<PersonnelResult>>
    {
        private readonly IRepository<Personnel> _repository;
        private readonly IMapper _mapper;

        public GetPersonnelQueryHandler(IRepository<Personnel> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<PersonnelResult>> Handle(GetPersonnelQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<PersonnelResult>>(values);
            return results;
        }
    }
}
