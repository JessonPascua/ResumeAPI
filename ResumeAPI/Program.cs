using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
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
            //builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ResumeAPI", Version = "v1" });
                c.OrderActionsBy((apiDesc) => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.HttpMethod}");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "ResumeAPI v1");
                if (app.Environment.IsProduction())
                {
                    options.RoutePrefix = string.Empty;
                }
            });

            await SeedData.MySeedData(app);

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}