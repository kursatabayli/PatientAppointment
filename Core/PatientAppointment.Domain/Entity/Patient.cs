using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public string IdentificationNumber { get; set; }
        public string PatientAddress { get; set; }
        public string PatientPhone { get; set; }
        public string PatientEmail { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
        public int? BloodTypeId { get; set; }
        public BloodType BloodType { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Prescription> Prescriptions { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<User> Users { get; set; }

    }
}
