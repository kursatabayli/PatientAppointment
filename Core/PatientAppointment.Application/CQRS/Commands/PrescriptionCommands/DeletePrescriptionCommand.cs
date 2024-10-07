using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.PrescriptionCommands
{
    public class DeletePrescriptionCommand : IRequest
    {
        public int Id { get; set; }

        public DeletePrescriptionCommand(int id)
        {
            Id = id;
        }
    }
}
