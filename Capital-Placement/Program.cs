
using Application.Interfaces;
using Application.Services;
using Infastructure;
using Infastructure.Repositories;
using Submission_Form.MappingProfile;

namespace Submission_Form
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ProgramDbContext>();

            builder.Services.AddScoped<IProgramService, ProgramService>();

            builder.Services.AddScoped<IProgramRepository, ProgramRepository>();
            builder.Services.AddAutoMapper(typeof(ProgramMapping));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
