using MediatR;
using PatientAppointment.Application.CQRS.Results.MedicationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Application.CQRS.Queries.MedicationQueries
{
    public class GetAllMedicationQuery : IRequest<List<MedicationResult>>
    {
    }
}
