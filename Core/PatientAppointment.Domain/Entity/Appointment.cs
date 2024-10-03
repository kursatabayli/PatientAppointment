using PatientAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan AppointmentTime { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int PolyclinicId { get; set; }
        public Polyclinic Polyclinic { get; set; }
        public int PersonnelId { get; set; }
        public Personnel Personnel { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public string? StatusDescription { get; set; }
    }
}
