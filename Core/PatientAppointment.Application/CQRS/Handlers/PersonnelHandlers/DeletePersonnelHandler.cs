using MediatR;
using PatientAppointment.Application.CQRS.Commands.PersonnelCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PersonnelHandlers
{
    public class DeletePersonnelHandler : IRequestHandler<DeletePersonnelCommand>
    {
        private readonly IRepository<Personnel> _repository;

        public DeletePersonnelHandler(IRepository<Personnel> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeletePersonnelCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
