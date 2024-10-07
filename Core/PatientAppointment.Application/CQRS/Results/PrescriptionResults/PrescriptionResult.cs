using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Results.PrescriptionResults
{
    public class PrescriptionResult
    {
        public int PrescriptionId { get; set; }
        public string Frequency { get; set; }
        public int MedicationId { get; set; }
        public int PatientId { get; set; }
        public int PersonnelId { get; set; }
    }
}
