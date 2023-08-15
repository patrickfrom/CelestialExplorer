using System.ComponentModel.DataAnnotations.Schema;
using CelestialExplorer.Api.CelestialObjectTypes;

namespace CelestialExplorer.Api.Models;

[Table("Stars")]
public record Star
{
    public int Id { get; set; }
    public string Name { get; set; }
    public StarType StarType { get; set; }
    public double Distance { get; set; }
    public double Luminosity { get; set; }
    public SpectralClass SpectralClass { get; set; }
    public double Mass { get; set; }
    
    public int GalaxyId { get; set; }
    public Galaxy Galaxy { get; set; }

    public ICollection<Planet> Planets = new List<Planet>();
};