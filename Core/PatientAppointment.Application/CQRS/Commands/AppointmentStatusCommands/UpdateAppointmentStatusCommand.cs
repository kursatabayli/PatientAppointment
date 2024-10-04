using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.AppointmentStatusCommands
{
    public class UpdateAppointmentStatusCommand : IRequest
    {
        public int AppointmentStatusId { get; set; }
        public string Status { get; set; }
    }
}
