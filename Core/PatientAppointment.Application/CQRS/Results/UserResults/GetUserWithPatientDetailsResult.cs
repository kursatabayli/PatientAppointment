using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Results.UserResults
{
    public class GetUserWithPatientDetailsResult
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? IdentificationNumber { get; set; }
        public int? PatientId { get; set; }
        public string PatientName { get; set; }
    }
}
