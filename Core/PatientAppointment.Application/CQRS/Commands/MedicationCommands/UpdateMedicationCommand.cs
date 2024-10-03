using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.MedicationCommands
{
    public class UpdateMedicationCommand : IRequest
    {
        public int MedicationId { get; set; }
        public string Name { get; set; }
    }
}
