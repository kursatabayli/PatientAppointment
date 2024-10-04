using AutoMapper;
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
        private readonly IMapper _mapper;

        public UpdatePolyclinicHandler(IRepository<Polyclinic> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdatePolyclinicCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.PolyclinicId);
            _mapper.Map(request, values);
            await _repository.UpdateAsync(values);
        }
    }
}
