using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.MedicationCommands
{
    public class DeleteMedicationCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteMedicationCommand(int id)
        {
            Id = id;
        }
    }
}
