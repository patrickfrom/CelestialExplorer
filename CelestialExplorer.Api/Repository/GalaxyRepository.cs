using CelestialExplorer.Api.Interfaces;
using CelestialExplorer.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CelestialExplorer.Api.Repository;

public class GalaxyRepository : IGalaxyRepository
{
    private readonly DatabaseContext _context;
    
    public GalaxyRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Galaxy>> GetGalaxies()
    {
        return await _context.Galaxies.ToListAsync();
    }

    public async Task<IEnumerable<Star>> GetStarsByGalaxyId(int id)
    {
        return await _context.Stars
            .Where(star => star.GalaxyId == id)
            .ToListAsync();
    }
}