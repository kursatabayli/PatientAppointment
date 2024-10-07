using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Results.AppointmentResults
{
    public class AppointmentResult
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public int PatientId { get; set; }
        public int PolyclinicId { get; set; }
        public int PersonnelId { get; set; }
        public int StatusId { get; set; }
        public string? StatusDescription { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
