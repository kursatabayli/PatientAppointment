using MediatR;
using PatientAppointment.Application.CQRS.Queries.AboutUsQueries;
using PatientAppointment.Application.CQRS.Results.AboutUsResults;
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
    public class GetAboutUsByIdQueryHandler : IRequestHandler<AboutUsByIdQuery, AboutUsResult>
    {
        private readonly IRepository<AboutUs> _repository;
        private readonly IMapper _mapper;

        public GetAboutUsByIdQueryHandler(IRepository<AboutUs> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AboutUsResult> Handle(AboutUsByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<AboutUsResult>(value);
            return result;
        }
    }
}
