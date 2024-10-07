using PatientAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? IdentificationNumber { get; set; }
        public string Password { get; set; }
        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
        public int? PersonnelId { get; set; }
        public Personnel? Personnel { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
