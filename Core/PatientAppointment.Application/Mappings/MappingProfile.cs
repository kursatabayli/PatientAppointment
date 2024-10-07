using AutoMapper;
using PatientAppointment.Application.CQRS.Commands.AboutUsCommands;
using PatientAppointment.Application.CQRS.Commands.AppointmentCommands;
using PatientAppointment.Application.CQRS.Commands.AppointmentStatusCommands;
using PatientAppointment.Application.CQRS.Commands.BloodTypeCommands;
using PatientAppointment.Application.CQRS.Commands.ContactCommands;
using PatientAppointment.Application.CQRS.Commands.LocationCommands;
using PatientAppointment.Application.CQRS.Commands.MedicationCommands;
using PatientAppointment.Application.CQRS.Commands.MessageCommands;
using PatientAppointment.Application.CQRS.Commands.PatientCommands;
using PatientAppointment.Application.CQRS.Commands.PersonnelCommands;
using PatientAppointment.Application.CQRS.Commands.PolyclinicCommands;
using PatientAppointment.Application.CQRS.Commands.PrescriptionCommands;
using PatientAppointment.Application.CQRS.Commands.UserCommands;
using PatientAppointment.Application.CQRS.Results.AboutUsResults;
using PatientAppointment.Application.CQRS.Results.AppointmentResults;
using PatientAppointment.Application.CQRS.Results.AppointmentStatusResults;
using PatientAppointment.Application.CQRS.Results.BloodTypeResults;
using PatientAppointment.Application.CQRS.Results.ContactResults;
using PatientAppointment.Application.CQRS.Results.GenderResults;
using PatientAppointment.Application.CQRS.Results.LocationResults;
using PatientAppointment.Application.CQRS.Results.MedicationResults;
using PatientAppointment.Application.CQRS.Results.MessageResults;
using PatientAppointment.Application.CQRS.Results.PatientResults;
using PatientAppointment.Application.CQRS.Results.PersonnelResults;
using PatientAppointment.Application.CQRS.Results.PolyclinicResults;
using PatientAppointment.Application.CQRS.Results.PrescriptionResults;
using PatientAppointment.Application.CQRS.Results.UserResults;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<AboutUs, AboutUsResult>();
            CreateMap<CreateAboutUsCommand, AboutUs>();
            CreateMap<UpdateAboutUsCommand, AboutUs>();
            
            CreateMap<Appointment, AppointmentResult>();
            CreateMap<CreateAppointmentCommand, Appointment>();
            CreateMap<UpdateAppointmentCommand, Appointment>();

            CreateMap<AppointmentStatus, AppointmentStatusResult>();
            CreateMap<CreateAppointmentStatusCommand, AppointmentStatus>();
            CreateMap<UpdateAppointmentStatusCommand, AppointmentStatus>();
            
            CreateMap<BloodType, BloodTypeResult>();
            CreateMap<CreateBloodTypeCommand, BloodType>();
            CreateMap<UpdateBloodTypeCommand, BloodType>();
            
            CreateMap<Contact, ContactResult>();
            CreateMap<CreateContactCommand, Contact>();
            CreateMap<UpdateContactCommand, Contact>();

            CreateMap<Gender, GenderResult>();
            
            CreateMap<Location, LocationResult>();
            CreateMap<CreateLocationCommand, Location>();
            CreateMap<UpdateLocationCommand, Location>();
            
            CreateMap<Medication, MedicationResult>();
            CreateMap<CreateMedicationCommand, Medication>();
            CreateMap<UpdateMedicationCommand, Medication>();
            
            CreateMap<Message, MessageResult>();
            CreateMap<CreateMessageCommand, Message>();
            CreateMap<UpdateMessageCommand, Message>();

            CreateMap<Polyclinic, PolyclinicResult>();
            CreateMap<CreatePolyclinicCommand, Polyclinic>();
            CreateMap<UpdatePolyclinicCommand, Polyclinic>();

            CreateMap<Patient, PatientResult>();
            CreateMap<CreatePatientCommand, Patient>();
            CreateMap<UpdatePatientCommand, Patient>();

            CreateMap<Personnel, PersonnelResult>();
            CreateMap<CreatePersonnelCommand, Personnel>();
            CreateMap<UpdatePersonnelCommand, Personnel>();
            
            CreateMap<Prescription, PrescriptionResult>();
            CreateMap<CreatePrescriptionCommand, Prescription>();
            CreateMap<UpdatePrescriptionCommand, Prescription>();
            
            CreateMap<User, UserResult>();
            CreateMap<CreateUserCommand, User>();
            CreateMap<UpdateUserCommand, User>();

            CreateMap<User, GetUserWithPatientDetailsResult>()
                .ForMember(dest => dest.PatientName,
                    opt => opt.MapFrom(src => src.Patient.PatientFirstName + " " + src.Patient.PatientLastName));

            CreateMap<User, GetUserWithPersonnelDetailsResult>()
                .ForMember(dest => dest.PersonnelName,
                    opt => opt.MapFrom(src => src.Personnel.PersonnelFirstName + " " + src.Personnel.PersonnelLastName));
        }
    }
}
