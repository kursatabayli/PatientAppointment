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
    public class DeletePolyclinicHandler : IRequestHandler<DeletePolyclinicCommand>
    {
        private readonly IRepository<Polyclinic> _repository;

        public DeletePolyclinicHandler(IRepository<Polyclinic> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeletePolyclinicCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
