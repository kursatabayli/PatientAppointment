using AutoMapper;
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
    public class CreateMessageHandler : IRequestHandler<CreateMessageCommand>
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public CreateMessageHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Message>(request);
            await _repository.CreateAsync(value);
        }
    }
}
