using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.BloodTypeCommands
{
    public class DeleteBloodTypeCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteBloodTypeCommand(int id)
        {
            Id = id;
        }
    }
}
