using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.MedicationCommands
{
    public class CreateMedicationCommand : IRequest
    {
        public string Name { get; set; }
    }
}
