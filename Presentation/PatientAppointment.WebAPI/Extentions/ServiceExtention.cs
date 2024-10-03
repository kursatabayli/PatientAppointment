using PatientAppointment.Domain.Interfaces;
using PatientAppointment.Persistence.Context;
using PatientAppointment.Persistence.Repositories;

namespace PatientAppointment.WebAPI.Extentions
{
    public static class ServiceExtention
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<PatientAppointmentContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
