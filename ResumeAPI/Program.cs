using Microsoft.EntityFrameworkCore;
using ResumeAPI.Data;
using System.Text.Json.Serialization;

namespace ResumeAPI
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("ResumeAPIContext") ?? throw new InvalidOperationException("Connection string 'ResumeAPIContext' not found.");
            builder.Services.AddDbContext<ResumeAPIContext>(options => options.UseNpgsql(connectionString));

            // Add services to the container.

            builder.Services.AddControllers();
            //builder.Services.AddControllers().AddJsonOptions(x =>
            //        x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            await SeedData.MySeedData(app);

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}