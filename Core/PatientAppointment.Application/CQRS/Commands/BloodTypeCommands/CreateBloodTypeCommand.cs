using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.BloodTypeCommands
{
    public class CreateBloodTypeCommand : IRequest
    {
        public string BloodTypes { get; set; }
    }
}
