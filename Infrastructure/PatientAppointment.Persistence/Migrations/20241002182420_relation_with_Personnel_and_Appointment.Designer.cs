﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientAppointment.Persistence.Context;

#nullable disable

namespace PatientAppointment.Persistence.Migrations
{
    [DbContext(typeof(PatientAppointmentContext))]
    [Migration("20241002182420_relation_with_Personnel_and_Appointment")]
    partial class relation_with_Personnel_and_Appointment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PatientAppointment.Domain.Entities.AboutUs", b =>
                {
                    b.Property<int>("AboutUsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AboutUsId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AboutUsId");

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Clinic", b =>
                {
                    b.Property<int>("ClinicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ClinicId"));

                    b.Property<string>("ClinicName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClinicId");

                    b.ToTable("Clinic");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ContactId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LocationUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Messages")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SenDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MessageId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<int?>("BloodTypeId")
                        .HasColumnType("int");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PatientAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PatientEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PatientFirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PatientLastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PatientPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PatientId");

                    b.HasIndex("BloodTypeId");

                    b.HasIndex("GenderId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Personnel", b =>
                {
                    b.Property<int>("PersonnelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PersonnelId"));

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LicenseExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MedicalLicenseNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonnelEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonnelFirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonnelLastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonnelPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonnelTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("longtext");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("PersonnelId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("GenderId");

                    b.ToTable("Personnel");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SocialMediaId"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SocialMediaName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SocialMediaId");

                    b.ToTable("SocialMedia");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Testimonial", b =>
                {
                    b.Property<int>("TestimonialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TestimonialId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("HospitalReview")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PersonnelReview")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TestimonialId");

                    b.HasIndex("PatientId");

                    b.ToTable("Testimonial");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("Date");

                    b.Property<TimeSpan>("AppointmentTime")
                        .HasColumnType("time(6)");

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("PersonnelId")
                        .HasColumnType("int");

                    b.Property<string>("StatusDescription")
                        .HasColumnType("longtext");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("PatientID");

                    b.HasIndex("PersonnelId");

                    b.HasIndex("StatusId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.BloodType", b =>
                {
                    b.Property<int>("BloodTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BloodTypeId"));

                    b.Property<string>("BloodTypes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BloodTypeId");

                    b.ToTable("BloodType");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("GenderId"));

                    b.Property<string>("Genders")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GenderId");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Medication", b =>
                {
                    b.Property<int>("MedicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MedicationId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MedicationId");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<DateTime>("DatePrescribed")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Frequency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MedicationId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PersonnelId")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("MedicationId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PersonnelId");

                    b.ToTable("Prescription");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonnelId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PersonnelId");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Patient", b =>
                {
                    b.HasOne("PatientAppointment.Domain.Entity.BloodType", "BloodType")
                        .WithMany("Patients")
                        .HasForeignKey("BloodTypeId");

                    b.HasOne("PatientAppointment.Domain.Entity.Gender", "Gender")
                        .WithMany("Patient")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BloodType");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Personnel", b =>
                {
                    b.HasOne("PatientAppointment.Domain.Entities.Clinic", "Clinic")
                        .WithMany("Personnels")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientAppointment.Domain.Entity.Gender", "Gender")
                        .WithMany("Personnel")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Testimonial", b =>
                {
                    b.HasOne("PatientAppointment.Domain.Entities.Patient", "Patient")
                        .WithMany("Testimonials")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Appointment", b =>
                {
                    b.HasOne("PatientAppointment.Domain.Entities.Clinic", "Clinic")
                        .WithMany("Appointments")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientAppointment.Domain.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientAppointment.Domain.Entities.Personnel", "Personnel")
                        .WithMany("Appointments")
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientAppointment.Domain.Entity.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Patient");

                    b.Navigation("Personnel");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Prescription", b =>
                {
                    b.HasOne("PatientAppointment.Domain.Entity.Medication", "Medication")
                        .WithMany("Prescriptions")
                        .HasForeignKey("MedicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientAppointment.Domain.Entities.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientAppointment.Domain.Entities.Personnel", "Personnel")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medication");

                    b.Navigation("Patient");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.User", b =>
                {
                    b.HasOne("PatientAppointment.Domain.Entities.Patient", "Patient")
                        .WithMany("Users")
                        .HasForeignKey("PatientId");

                    b.HasOne("PatientAppointment.Domain.Entities.Personnel", "Personnel")
                        .WithMany("Users")
                        .HasForeignKey("PersonnelId");

                    b.HasOne("PatientAppointment.Domain.Entity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Personnel");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Clinic", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Prescriptions");

                    b.Navigation("Testimonials");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entities.Personnel", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Prescriptions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.BloodType", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Gender", b =>
                {
                    b.Navigation("Patient");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Medication", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("PatientAppointment.Domain.Entity.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
