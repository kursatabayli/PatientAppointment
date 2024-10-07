using MediatR;
using PatientAppointment.Domain.Entities;
using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.PrescriptionCommands
{
    public class CreatePrescriptionCommand : IRequest
    {
        public string Frequency { get; set; }
        public int MedicationId { get; set; }
        public int PatientId { get; set; }
        public int PersonnelId { get; set; }
    }
}
