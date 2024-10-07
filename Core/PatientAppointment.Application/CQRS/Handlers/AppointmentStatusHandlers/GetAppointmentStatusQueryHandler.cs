using AutoMapper;
using MediatR;
using PatientAppointment.Application.CQRS.Queries.AppointmentStatusQueries;
using PatientAppointment.Application.CQRS.Results.AppointmentStatusResults;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Handlers.AppointmentStatusHandlers
{
    public class GetAppointmentStatusQueryHandler : IRequestHandler<GetAppointmentStatusQuery, List<AppointmentStatusResult>>
    {
        private readonly IRepository<AppointmentStatus> _repository;
        private readonly IMapper _mapper;

        public GetAppointmentStatusQueryHandler(IRepository<AppointmentStatus> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<AppointmentStatusResult>> Handle(GetAppointmentStatusQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<AppointmentStatusResult>>(values);
            return results;
        }
    }
}
