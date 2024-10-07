using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entity
{
    public class AppointmentStatus
    {
        public int AppointmentStatusId { get; set; }
        public string Status { get; set; }
        List<Appointment> Appointments { get; set; }
    }
}
