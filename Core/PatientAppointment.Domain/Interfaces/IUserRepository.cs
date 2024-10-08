using PatientAppointment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUserWithPatientDetails();
        Task<List<User>> GetUserWithPersonnelDetails();
    }
}
