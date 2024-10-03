using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.LocationCommands
{
    public class CreateLocationCommand : IRequest
    {
        public string LocationName { get; set; }
        public string LocationUrl { get; set; }
    }
}
