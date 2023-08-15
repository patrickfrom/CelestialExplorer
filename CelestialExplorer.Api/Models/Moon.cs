using System.ComponentModel.DataAnnotations.Schema;

namespace CelestialExplorer.Api.Models;

[Table("Moons")]
public record Moon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Size { get; set; }
    public double DistanceFromPlanet { get; set; }
    public double OrbitalPeriod { get; set; }
    
    public int PlanetId { get; set; }
    public Planet Planet { get; set; }
}