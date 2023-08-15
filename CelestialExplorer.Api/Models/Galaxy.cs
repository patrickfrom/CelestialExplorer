using System.ComponentModel.DataAnnotations.Schema;
using CelestialExplorer.Api.CelestialObjectTypes;

namespace CelestialExplorer.Api.Models;

[Table("Galaxies")]
public record Galaxy
{
    public int Id { get; set; }
    public string Name { get; set; }
    public GalaxyType Type { get; set; }
    public double Distance { get; set; }
    public int NumberOfStars { get; set; }
    public double Size { get; set; }
    public int Age { get; set; }

    public ICollection<Star> Stars = new List<Star>();
    public ICollection<Nebula> Nebulae = new List<Nebula>();
}