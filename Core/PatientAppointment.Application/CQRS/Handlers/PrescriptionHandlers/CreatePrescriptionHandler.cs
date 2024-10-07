using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.PrescriptionCommands;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PrescriptionHandlers
{
    public class CreatePrescriptionHandler : IRequestHandler<CreatePrescriptionCommand>
    {
        private readonly IRepository<Prescription> _repository;
        private readonly IMapper _mapper;

        public CreatePrescriptionHandler(IRepository<Prescription> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreatePrescriptionCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Prescription>(request);
            await _repository.CreateAsync(value);
        }
    }
}
