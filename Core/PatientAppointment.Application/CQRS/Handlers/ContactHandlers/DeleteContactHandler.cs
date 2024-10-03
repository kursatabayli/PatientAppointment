using MediatR;
using PatientAppointment.Application.CQRS.Commands.ContactCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.ContactHandlers
{
    public class DeleteContactHandler : IRequestHandler<DeleteContactCommand>
    {
        private readonly IRepository<Contact> _repository;

        public DeleteContactHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
