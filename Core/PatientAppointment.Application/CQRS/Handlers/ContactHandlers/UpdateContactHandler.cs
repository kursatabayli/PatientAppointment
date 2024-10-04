using AutoMapper;
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
    public class UpdateContactHandler : IRequestHandler<UpdateContactCommand>
    {
        private readonly IRepository<Contact> _repository;
        private readonly IMapper _mapper;

        public UpdateContactHandler(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ContactId);
            _mapper.Map(request, values);
            await _repository.UpdateAsync(values);
        }
    }
}
