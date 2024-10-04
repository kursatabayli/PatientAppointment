using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.BloodTypeCommands;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.BloodTypeHandlers
{
    public class CreateBloodTypeHandler : IRequestHandler<CreateBloodTypeCommand>
    {
        private readonly IRepository<BloodType> _repository;
        private readonly IMapper _mapper;

        public CreateBloodTypeHandler(IRepository<BloodType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateBloodTypeCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<BloodType>(request);
            await _repository.CreateAsync(value);
        }
    }
}
