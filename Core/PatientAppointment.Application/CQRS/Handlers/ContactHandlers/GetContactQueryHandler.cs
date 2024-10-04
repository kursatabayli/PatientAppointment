using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.ContactQueries;
using PatientAppointment.Application.CQRS.Results.ContactResults;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler : IRequestHandler<GetContactQuery, List<ContactResult>>
    {
        private readonly IRepository<Contact> _repository;
        private readonly IMapper _mapper;

        public GetContactQueryHandler(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ContactResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<ContactResult>>(values);
            return results;
        }
    }
}
