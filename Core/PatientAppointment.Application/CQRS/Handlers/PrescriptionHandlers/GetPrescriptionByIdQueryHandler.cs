using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.PrescriptionQueries;
using PatientAppointment.Application.CQRS.Results.PrescriptionResults;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.PrescriptionHandlers
{
    public class GetPrescriptionByIdQueryHandler : IRequestHandler<GetPrescriptionByIdQuery, PrescriptionResult>
    {
        private readonly IRepository<Prescription> _repository;
        private readonly IMapper _mapper;

        public GetPrescriptionByIdQueryHandler(IRepository<Prescription> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PrescriptionResult> Handle(GetPrescriptionByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<PrescriptionResult>(value);
            return result;
        }
    }
}
