using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.PolyclinicCommands
{
    public class DeletePolyclinicCommand : IRequest
    {
        public int Id { get; set; }

        public DeletePolyclinicCommand(int id)
        {
            Id = id;
        }
    }
}
