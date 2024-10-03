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

        public CreateBloodTypeHandler(IRepository<BloodType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBloodTypeCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new BloodType
            {
                BloodTypes = request.BloodTypes
            });
        }
    }
}
