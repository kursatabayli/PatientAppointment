using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.PatientCommands;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PatientHandlers
{
    public class UpdatePatientHandler : IRequestHandler<UpdatePatientCommand>
    {
        private readonly IRepository<Patient> _repository;
        private readonly IMapper _mapper;
        public UpdatePatientHandler(IRepository<Patient> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.PatientId);
            _mapper.Map(request, value);
            await _repository.UpdateAsync(value);
        }
    }
}
