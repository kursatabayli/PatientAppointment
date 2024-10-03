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

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<ContactResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new ContactResult
            {
                ContactId = value.ContactId,
                Title = value.Title,
                Address = value.Address,
                Phone = value.Phone,
                Email = value.Email,
                Description = value.Description,
            };
        }
    }
}
