using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.AppointmentCommands
{
    public class CreateAppointmentCommand : IRequest
    {
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public int PatientId { get; set; }
        public int PolyclinicId { get; set; }
        public int PersonnelId { get; set; }
        public int StatusId { get; set; }
        public string? StatusDescription { get; set; }

        public DateTime CreatedDate = DateTime.Now;
    }
}
