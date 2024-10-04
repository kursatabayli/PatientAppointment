using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.PolyclinicCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PolyclinicHandlers
{
    public class CreatePolyclinicHandler : IRequestHandler<CreatePolyclinicCommand>
    {
        private readonly IRepository<Polyclinic> _repository;
        private readonly IMapper _mapper;

        public CreatePolyclinicHandler(IRepository<Polyclinic> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatePolyclinicCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Polyclinic>(request);
            await _repository.CreateAsync(value);
        }
    }
}
