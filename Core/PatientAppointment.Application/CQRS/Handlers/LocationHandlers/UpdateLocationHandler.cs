using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.LocationCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.LocationHandlers
{
    public class UpdateLocationHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mapper;

        public UpdateLocationHandler(IRepository<Location> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.LocationId);
            _mapper.Map(request, values);
            await _repository.UpdateAsync(values);
        }
    }
}
