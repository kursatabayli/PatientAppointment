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
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, ContactResult>
    {
        private readonly IRepository<Contact> _repository;
        private readonly IMapper _mapper;

        public GetContactByIdQueryHandler(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ContactResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<ContactResult>(value);
            return result;
        }
    }
}
