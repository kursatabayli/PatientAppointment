using PatientAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entity
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string Genders { get; set; }
        public List<Patient> Patient { get; set; }
        public List<Personnel> Personnel  { get; set; }
    }
}
