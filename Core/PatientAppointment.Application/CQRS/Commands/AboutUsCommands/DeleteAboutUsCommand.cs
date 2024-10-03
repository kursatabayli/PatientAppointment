using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.AboutUsCommands
{
    public class DeleteAboutUsCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteAboutUsCommand(int id)
        {
            Id = id;
        }
    }
}
