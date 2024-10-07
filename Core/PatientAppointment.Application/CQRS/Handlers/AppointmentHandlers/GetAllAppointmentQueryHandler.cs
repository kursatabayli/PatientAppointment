using MediatR;
using PatientAppointment.Application.CQRS.Queries.AppointmentQueries;
using PatientAppointment.Application.CQRS.Results.AppointmentResults;
using PatientAppointment.Domain.Interfaces;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PatientAppointment.Application.CQRS.Handlers.AppointmentHandlers
{
    public class GetAllAppointmentQueryHandler : IRequestHandler<GetAllAppointmentQuery, List<AppointmentResult>>
    {
        private readonly IRepository<Appointment> _repository;
        private readonly IMapper _mapper;

        public GetAllAppointmentQueryHandler(IRepository<Appointment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<AppointmentResult>> Handle(GetAllAppointmentQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var results = _mapper.Map<List<AppointmentResult>>(values);
            return results;
        }
    }
}
