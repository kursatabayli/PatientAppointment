using MediatR;
using PatientAppointment.Application.CQRS.Queries.BloodTypeQueries;
using PatientAppointment.Application.CQRS.Results.BloodTypeResults;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.BloodTypeHandlers
{
    public class GetBloodTypeQueryHandler : IRequestHandler<BloodTypeQuery, List<BloodTypeResult>>
    {
        private readonly IRepository<BloodType> _repository;

        public GetBloodTypeQueryHandler(IRepository<BloodType> repository)
        {
            _repository = repository;
        }

        public async Task<List<BloodTypeResult>> Handle(BloodTypeQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new BloodTypeResult
            {
                BloodTypeId = x.BloodTypeId,
                BloodTypes = x.BloodTypes
            }).ToList();
        }
    }
}
