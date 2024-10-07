using AutoMapper;
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
    public class UpdatePersonnelHandler : IRequestHandler<UpdatePersonnelCommand>
    {
        private readonly IRepository<Personnel> _repository;
        private readonly IMapper _mapper;

        public UpdatePersonnelHandler(IRepository<Personnel> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdatePersonnelCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.PersonnelId);
            _mapper.Map(request, value);
            await _repository.UpdateAsync(value);
        }
    }
}
