using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Results.AppointmentStatusResults
{
    public class AppointmentStatusResult
    {
        public int AppointmentStatusId { get; set; }
        public string Status { get; set; }
    }
}
