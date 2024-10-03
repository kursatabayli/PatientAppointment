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
    public class UpdatePolyclinicHandler : IRequestHandler<UpdatePolyclinicCommand>
    {
        private readonly IRepository<Polyclinic> _repository;

        public UpdatePolyclinicHandler(IRepository<Polyclinic> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePolyclinicCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.PolyclinicId);
            values.PolyclinicName = request.PolyclinicName;
            await _repository.UpdateAsync(values);
        }
    }
}
