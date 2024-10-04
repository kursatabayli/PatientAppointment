using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PatientAppointment.Application.Services
{
	public static class ServiceRegistiration
	{
		public static void AddApplicationService(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
