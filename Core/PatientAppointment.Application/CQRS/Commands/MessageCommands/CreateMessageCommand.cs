using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.MessageCommands
{
    public class CreateMessageCommand : IRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Messages { get; set; }

        public DateTime SendDate = DateTime.Now;
    }
}
