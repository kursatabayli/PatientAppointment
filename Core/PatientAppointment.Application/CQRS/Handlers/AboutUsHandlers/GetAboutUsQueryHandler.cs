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

namespace PatientAppointment.Application.CQRS.Handlers.AboutUsHandlers
{
    public class GetAboutUsQueryHandler : IRequestHandler<AboutUsQuery, List<AboutUsResult>>
    {
        private readonly IRepository<AboutUs> _repository;

        public GetAboutUsQueryHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task<List<AboutUsResult>> Handle(AboutUsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new AboutUsResult
            {
                AboutUsId = x.AboutUsId,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
            }).ToList();
        }
    }
}
