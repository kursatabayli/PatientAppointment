using AutoMapper;
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
        private readonly IMapper _mapper;

        public CreateContactHandler(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Contact>(request);
            await _repository.CreateAsync(value);
        }
    }
}
