using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Persistence.Context
{
    public class PatientAppointmentContext : DbContext
    {
        public PatientAppointmentContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<AppointmentStatus> AppointmentStatus { get; set; }
        public DbSet<BloodType> BloodType { get; set; }
        public DbSet<Polyclinic> Polyclinic { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<User> User { get; set; }

    }
}
