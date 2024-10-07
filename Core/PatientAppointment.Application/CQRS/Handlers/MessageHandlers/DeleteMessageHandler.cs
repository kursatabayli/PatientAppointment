using MediatR;
using PatientAppointment.Application.CQRS.Commands.MessageCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.MessageHandlers
{
    public class DeleteMessageHandler : IRequestHandler<DeleteMessageCommand>
    {
        private readonly IRepository<Message> _repository;

        public DeleteMessageHandler(IRepository<Message> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
