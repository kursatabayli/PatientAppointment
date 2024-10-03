using PatientAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entity
{
    public class BloodType
    {
        public int BloodTypeId { get; set; }
        public string BloodTypes { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
