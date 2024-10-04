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
    public class GetAboutUsQueryHandler : IRequestHandler<AboutUsQuery, List<AboutUsResult>>
    {
        private readonly IRepository<AboutUs> _repository;
        private readonly IMapper _mapper;

        public GetAboutUsQueryHandler(IRepository<AboutUs> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<AboutUsResult>> Handle(AboutUsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<AboutUsResult>>(values);
            return results;
        }
    }
}
