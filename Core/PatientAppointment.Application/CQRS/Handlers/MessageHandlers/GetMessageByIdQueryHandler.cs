using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.MessageQueries;
using PatientAppointment.Application.CQRS.Results.MessageResults;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;

namespace PatientAppointment.Application.CQRS.Handlers.MessageHandlers
{
    public class GetMessageByIdQueryHandler : IRequestHandler<GetMessageByIdQuery, MessageResult>
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public GetMessageByIdQueryHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MessageResult> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<MessageResult>(value);
            return result;
        }
    }
}
