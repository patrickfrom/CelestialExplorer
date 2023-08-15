using System.ComponentModel.DataAnnotations.Schema;
using CelestialExplorer.Api.CelestialObjectTypes;

namespace CelestialExplorer.Api.Models;

[Table("Nebulae")]
public record Nebula
{
    public int Id { get; set; }
    public string Name { get; set; }
    public NebulaType NebulaType { get; set; }
    public double Size { get; set; }
    public string Description { get; set; }
    
    public int GalaxyId { get; set; }
    public Galaxy Galaxy { get; set; }
}