using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entities
{
    public class Polyclinic
    {
        public int PolyclinicId { get; set; }
        public string PolyclinicName { get; set; }
        public List<Personnel> Personnels { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
