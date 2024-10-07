using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Results.UserResults
{
    public class GetUserWithPersonnelDetailsResult
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? IdentificationNumber { get; set; }
        public int? PersonnelId { get; set; }
        public string PersonnelName { get; set; }
    }
}
