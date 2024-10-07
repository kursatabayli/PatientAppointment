using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.PersonnelCommands
{
    public class DeletePersonnelCommand : IRequest
    {
        public int Id { get; set; }

        public DeletePersonnelCommand(int id)
        {
            Id = id;
        }
    }
}
