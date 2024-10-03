using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entity
{
    public class Medication
    {
        public int MedicationId { get; set; }
        public string Name { get; set; }
        public List<Prescription> Prescriptions { get; set; }
    }
}
