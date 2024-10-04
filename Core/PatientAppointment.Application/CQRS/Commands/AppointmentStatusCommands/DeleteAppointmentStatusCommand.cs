using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.AppointmentStatusCommands
{
    public class DeleteAppointmentStatusCommand:IRequest
    {
        public int Id { get; set; }

        public DeleteAppointmentStatusCommand(int id)
        {
            Id = id;
        }
    }
}
