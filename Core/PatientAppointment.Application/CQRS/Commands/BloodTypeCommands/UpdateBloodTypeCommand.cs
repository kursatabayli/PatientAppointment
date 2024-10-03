using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Commands.BloodTypeCommands
{
    public class UpdateBloodTypeCommand : IRequest
    {
        public int BloodTypeId { get; set; }
        public string BloodTypes { get; set; }
    }
}
