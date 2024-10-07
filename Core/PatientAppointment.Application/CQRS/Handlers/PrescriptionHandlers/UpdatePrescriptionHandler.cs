using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Commands.PrescriptionCommands;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PrescriptionHandlers
{
    public class UpdatePrescriptionHandler : IRequestHandler<UpdatePrescriptionCommand>
    {
        private readonly IRepository<Prescription> _repository;
        private readonly IMapper _mapper;

        public UpdatePrescriptionHandler(IRepository<Prescription> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdatePrescriptionCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.PrescriptionId);
            _mapper.Map(request, value);
            await _repository.UpdateAsync(value);
        }
    }
}
