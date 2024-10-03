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
    public class GetBloodTypeByIdQueryHandler : IRequestHandler<BloodTypeByIdQuery, BloodTypeResult>
    {
        private readonly IRepository<BloodType> _repository;

        public GetBloodTypeByIdQueryHandler(IRepository<BloodType> repository)
        {
            _repository = repository;
        }

        public async Task<BloodTypeResult> Handle(BloodTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new BloodTypeResult
            {
                BloodTypeId = values.BloodTypeId,
                BloodTypes = values.BloodTypes
            };
        }
    }
}
