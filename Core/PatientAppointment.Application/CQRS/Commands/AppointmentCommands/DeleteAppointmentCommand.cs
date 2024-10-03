using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.AppointmentCommands
{
    public class DeleteAppointmentCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteAppointmentCommand(int id)
        {
            Id = id;
        }
    }
}
