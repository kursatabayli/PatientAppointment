using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Results.PersonnelResults
{
    public class PersonnelResult
    {
        public int PersonnelId { get; set; }
        public string PersonnelFirstName { get; set; }
        public string PersonnelLastName { get; set; }
        public string PersonnelTitle { get; set; }
        public int GenderId { get; set; }
        public string IdentificationNumber { get; set; }
        public string PersonnelPhone { get; set; }
        public string PersonnelEmail { get; set; }
        public string MedicalLicenseNumber { get; set; }
        public DateTime LicenseExpirationDate { get; set; }
        public int YearsOfExperience { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public int PolyclinicId { get; set; }
        public string RoomName { get; set; }
    }
}
