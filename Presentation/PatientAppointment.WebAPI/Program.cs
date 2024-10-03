using PatientAppointment.Application.Services;
using PatientAppointment.WebAPI.Extentions;

namespace PatientAppointment.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddDbContextConfiguration(builder.Configuration);
            builder.Services.RegisterServices();
            builder.Services.AddApplicationService(builder.Configuration);
            builder.Services.AddSwaggerDocumentation();


            var app = builder.Build();

            app.UseSwaggerDocumentation(app.Environment);

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
