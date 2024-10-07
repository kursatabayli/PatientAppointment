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
    public class GetPersonnelByIdQueryHandler:IRequestHandler<GetPersonnelByIdQuery, PersonnelResult>
    {
        private readonly IRepository<Personnel> _repository;
        private readonly IMapper _mapper;

        public GetPersonnelByIdQueryHandler(IRepository<Personnel> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<PersonnelResult> Handle(GetPersonnelByIdQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<PersonnelResult>(value);
            return result;
        }
    }
}
