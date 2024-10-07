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
    internal class UpdateMessageHandler : IRequestHandler<UpdateMessageCommand>
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public UpdateMessageHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.MessageId);
            _mapper.Map(request, value);
            await _repository.UpdateAsync(value);
        }
    }
}
