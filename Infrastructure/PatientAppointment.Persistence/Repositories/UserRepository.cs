using Microsoft.EntityFrameworkCore;
using PatientAppointment.Domain.Entity;
using PatientAppointment.Domain.Interfaces;
using PatientAppointment.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PatientAppointmentContext _context;

        public UserRepository(PatientAppointmentContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUserWithPatientDetails()
        {
            return await _context.User.Include(x => x.Patient).Where(x => x.PatientId != null).ToListAsync();
        }

        public async Task<List<User>> GetUserWithPersonnelDetails()
        {
            return await _context.User.Include(x => x.Personnel).Where(x => x.PersonnelId != null).ToListAsync();
        }
    }
}
