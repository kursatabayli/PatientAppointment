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

        public CreatePolyclinicHandler(IRepository<Polyclinic> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatePolyclinicCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Polyclinic
            {
                PolyclinicName = request.PolyclinicName
            });
        }
    }
}
