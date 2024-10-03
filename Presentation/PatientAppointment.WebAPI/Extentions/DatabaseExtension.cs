using Microsoft.EntityFrameworkCore;
using PatientAppointment.Persistence.Context;

namespace PatientAppointment.WebAPI.Extentions
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PatientAppointmentContext>(options =>
                options.UseMySql(
                    configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(8, 0, 38))
                ));

            return services;
        }
    }
}
