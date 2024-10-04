using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.MessageQueries;
using PatientAppointment.Application.CQRS.Results.MessageResults;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.MessageHandlers
{
    public class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, List<MessageResult>>
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public GetMessageQueryHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<MessageResult>> Handle(GetMessageQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<MessageResult>>(values);
            return results;
        }
    }
}
