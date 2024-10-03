using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entity
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        List<Appointment> Appointments { get; set; }
    }
}
