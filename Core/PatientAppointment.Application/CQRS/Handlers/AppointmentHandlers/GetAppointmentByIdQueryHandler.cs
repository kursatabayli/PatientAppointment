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
    public class GetAppointmentByIdQueryHandler : IRequestHandler<AppointmentByIdQuery, AppointmentResult>
    {
        private readonly IRepository<Appointment> _repository;
        private readonly IMapper _mapper;

        public GetAppointmentByIdQueryHandler(IRepository<Appointment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AppointmentResult> Handle(AppointmentByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<AppointmentResult>(value);
            return result;
        }
    }
}
