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

        public List<User> GetUserWithDetails()
        {
            var values = _context.User.Include(x => x.Patient).ThenInclude(y => y.Gender).Include(x => x.Personnel).ToList();
            return values;
        }
    }
}
