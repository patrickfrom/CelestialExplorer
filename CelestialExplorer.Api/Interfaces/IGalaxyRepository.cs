using CelestialExplorer.Api.Models;

namespace CelestialExplorer.Api.Interfaces;

public interface IGalaxyRepository
{
    Task<IEnumerable<Galaxy>> GetGalaxies();
    Task<IEnumerable<Star>> GetStarsByGalaxyId(int id);
}