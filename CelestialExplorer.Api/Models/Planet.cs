using System.ComponentModel.DataAnnotations.Schema;
using CelestialExplorer.Api.CelestialObjectTypes;

namespace CelestialExplorer.Api.Models;

[Table("Planets")]
public record Planet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public PlanetType PlanetType { get; set; }
    public double Size { get; set; }
    public double DistanceFromStar { get; set; }
    public double OrbitalPeriod { get; set; }

    
    public int StarId { get; set; }
    public Star Star { get; set; }
    
    public ICollection<Moon> Moons = new List<Moon>();
}