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
    public class DeleteBloodTypeHandler : IRequestHandler<DeleteBloodTypeCommand>
    {
        private readonly IRepository<BloodType> _repository;

        public DeleteBloodTypeHandler(IRepository<BloodType> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBloodTypeCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
