﻿// <auto-generated />
using CelestialExplorer.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CelestialExplorer.Api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230815191320_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CelestialExplorer.Api.Models.Galaxy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfStars")
                        .HasColumnType("int");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("pk_GalaxyId");

                    b.ToTable("Galaxies");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Moon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DistanceFromPlanet")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrbitalPeriod")
                        .HasColumnType("float");

                    b.Property<int>("PlanetId")
                        .HasColumnType("int");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.ToTable("Moons");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Nebula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GalaxyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NebulaType")
                        .HasColumnType("int");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GalaxyId");

                    b.ToTable("Nebulae");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DistanceFromStar")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrbitalPeriod")
                        .HasColumnType("float");

                    b.Property<int>("PlanetType")
                        .HasColumnType("int");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<int>("StarId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("pk_PlanetId");

                    b.HasIndex("StarId");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<int>("GalaxyId")
                        .HasColumnType("int");

                    b.Property<double>("Luminosity")
                        .HasColumnType("float");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpectralClass")
                        .HasColumnType("int");

                    b.Property<int>("StarType")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("pk_StarId");

                    b.HasIndex("GalaxyId");

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Moon", b =>
                {
                    b.HasOne("CelestialExplorer.Api.Models.Planet", "Planet")
                        .WithMany()
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Nebula", b =>
                {
                    b.HasOne("CelestialExplorer.Api.Models.Galaxy", "Galaxy")
                        .WithMany("Nebulae")
                        .HasForeignKey("GalaxyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Galaxy");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Planet", b =>
                {
                    b.HasOne("CelestialExplorer.Api.Models.Star", "Star")
                        .WithMany("Planets")
                        .HasForeignKey("StarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Star");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Star", b =>
                {
                    b.HasOne("CelestialExplorer.Api.Models.Galaxy", "Galaxy")
                        .WithMany("Stars")
                        .HasForeignKey("GalaxyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Galaxy");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Galaxy", b =>
                {
                    b.Navigation("Nebulae");

                    b.Navigation("Stars");
                });

            modelBuilder.Entity("CelestialExplorer.Api.Models.Star", b =>
                {
                    b.Navigation("Planets");
                });
#pragma warning restore 612, 618
        }
    }
}