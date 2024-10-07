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
    public class CreateAboutUsHandler : IRequestHandler<CreateAboutUsCommand>
    {
        private readonly IRepository<AboutUs> _repository;
        private readonly IMapper _mapper;

        public CreateAboutUsHandler(IRepository<AboutUs> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAboutUsCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<AboutUs>(request);
            await _repository.CreateAsync(value);
        }
    }
}
