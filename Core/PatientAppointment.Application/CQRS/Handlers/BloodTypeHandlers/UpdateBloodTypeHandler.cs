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
    public class UpdateBloodTypeHandler : IRequestHandler<UpdateBloodTypeCommand>
    {
        private readonly IRepository<BloodType> _repository;
        private readonly IMapper _mapper;

        public UpdateBloodTypeHandler(IRepository<BloodType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateBloodTypeCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BloodTypeId);
            _mapper.Map(request, values);
            await _repository.UpdateAsync(values);
        }
    }
}
