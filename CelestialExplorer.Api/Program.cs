using CelestialExplorer.Api.Interfaces;
using CelestialExplorer.Api.Repository;
using Microsoft.EntityFrameworkCore;

namespace CelestialExplorer.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        builder.Services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseSqlServer(@"Server=(localdb)\Local;Database=CelestialExplorer");
        });
        
        builder.Services.AddScoped<IGalaxyRepository, GalaxyRepository>();

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