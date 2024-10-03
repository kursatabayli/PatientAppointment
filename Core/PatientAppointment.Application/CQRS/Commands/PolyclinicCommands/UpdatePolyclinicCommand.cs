using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.PolyclinicCommands
{
    public class UpdatePolyclinicCommand : IRequest
    {
        public int PolyclinicId { get; set; }
        public string PolyclinicName { get; set; }
    }
}
