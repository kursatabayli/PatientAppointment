using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Results.PatientResults
{
    public class PatientResult
    {
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public int GenderId { get; set; }
        public string IdentificationNumber { get; set; }
        public string PatientAddress { get; set; }
        public string PatientPhone { get; set; }
        public string PatientEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? BloodTypeId { get; set; }
    }
}
