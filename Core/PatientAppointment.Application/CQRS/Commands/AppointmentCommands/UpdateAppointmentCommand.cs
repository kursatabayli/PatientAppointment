using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.AppointmentCommands
{
    public class UpdateAppointmentCommand : IRequest
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public int PatientID { get; set; }
        public int PolyclinicId { get; set; }
        public int PersonnelId { get; set; }
        public int StatusId { get; set; }
        public string? StatusDescription { get; set; }
    }
}
