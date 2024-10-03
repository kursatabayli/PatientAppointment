using PatientAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entity
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public string Frequency { get; set; }
        public DateTime DatePrescribed { get; set; }
        public int MedicationId { get; set; }
        public Medication Medication { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int PersonnelId { get; set; }
        public Personnel Personnel { get; set; }


    }
}
