using System.ComponentModel.DataAnnotations.Schema;
using CelestialExplorer.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CelestialExplorer.Api;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    
    public DbSet<Galaxy> Galaxies { get; set; }
    public DbSet<Nebula> Nebulae { get; set; }
    public DbSet<Star> Stars { get; set; }

    public DbSet<Planet> Planets { get; set; }
    public DbSet<Moon> Moons { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Galaxy>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_GalaxyId");
            
            entity.HasMany(e => e.Stars)
                .WithOne(e => e.Galaxy)
                .HasForeignKey(e => e.GalaxyId);

            entity.HasMany(e => e.Nebulae)
                .WithOne(e => e.Galaxy)
                .HasForeignKey(e => e.GalaxyId);
        });

        modelBuilder.Entity<Star>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_StarId");

            entity.HasMany(e => e.Planets)
                .WithOne(e => e.Star)
                .HasForeignKey(e => e.StarId);
        });

        modelBuilder.Entity<Planet>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_PlanetId");

            entity.HasMany<Moon>()
                .WithOne(e => e.Planet)
                .HasForeignKey(e => e.PlanetId);
        });
    }
}