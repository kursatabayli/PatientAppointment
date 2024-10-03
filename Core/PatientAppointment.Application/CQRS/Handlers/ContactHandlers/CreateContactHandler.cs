using MediatR;
using PatientAppointment.Application.CQRS.Commands.ContactCommands;
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
    public class CreateContactHandler : IRequestHandler<CreateContactCommand>
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Contact
            {
                Title = request.Title,
                Address = request.Address,
                Phone = request.Phone,
                Email = request.Email,
                Description = request.Description
            });
        }
    }
}
