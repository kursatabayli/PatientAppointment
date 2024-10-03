using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Results.LocationResults
{
    public class LocationResult
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationUrl { get; set; }
    }
}
