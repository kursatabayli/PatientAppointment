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
    public class GetAboutUsByIdQueryHandler : IRequestHandler<AboutUsByIdQuery, AboutUsResult>
    {
        private readonly IRepository<AboutUs> _repository;

        public GetAboutUsByIdQueryHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task<AboutUsResult> Handle(AboutUsByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new AboutUsResult
            {
                AboutUsId = values.AboutUsId,
                Title = values.Title,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
            };
        }
    }
}
