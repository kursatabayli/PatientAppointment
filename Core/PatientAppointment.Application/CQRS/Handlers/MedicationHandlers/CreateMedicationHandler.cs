using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.MedicationCommands;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.MedicationHandlers
{
    public class CreateMedicationHandler : IRequestHandler<CreateMedicationCommand>
    {
        private readonly IRepository<Medication> _repository;
        private readonly IMapper _mapper;

        public CreateMedicationHandler(IRepository<Medication> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateMedicationCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Medication>(request);
            await _repository.CreateAsync(value);
        }
    }
}
