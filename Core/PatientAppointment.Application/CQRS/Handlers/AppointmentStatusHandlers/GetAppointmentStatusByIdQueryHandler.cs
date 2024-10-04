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
    public class GetAppointmentStatusByIdQueryHandler:IRequestHandler<GetAppointmentStatusByIdQuery, AppointmentStatusResult>
    {
        private readonly IRepository<AppointmentStatus> _repository;
        private readonly IMapper _mapper;

        public GetAppointmentStatusByIdQueryHandler(IRepository<AppointmentStatus> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AppointmentStatusResult> Handle(GetAppointmentStatusByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            var result = _mapper.Map<AppointmentStatusResult>(value);
            return result;
        }
    }
}
