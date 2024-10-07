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
    public class GetAllPrescriptionQueryHandler : IRequestHandler<GetAllPrescriptionQuery, List<PrescriptionResult>>
    {
        private readonly IRepository<Prescription> _repository;
        private readonly IMapper _mapper;

        public GetAllPrescriptionQueryHandler(IRepository<Prescription> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<PrescriptionResult>> Handle(GetAllPrescriptionQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<PrescriptionResult>>(values);
            return results;
        }
    }
}
