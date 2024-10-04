using MediatR;
using PatientAppointment.Application.CQRS.Commands.AboutUsCommands;
using PatientAppointment.Domain.Interfaces;
using PatientAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PatientAppointment.Application.CQRS.Handlers.AboutUsHandlers
{
    public class UpdateAboutUsHandler : IRequestHandler<UpdateAboutUsCommand>
    {
        private readonly IRepository<AboutUs> _repository;
        private readonly IMapper _mapper;

        public UpdateAboutUsHandler(IRepository<AboutUs> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAboutUsCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AboutUsId);
            _mapper.Map(request, values);
            await _repository.UpdateAsync(values);
        }
    }
}
