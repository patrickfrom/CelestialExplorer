using System.Data;
using CelestialExplorer.Api.Interfaces;
using CelestialExplorer.Api.Models;
using CelestialExplorer.Api.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CelestialExplorer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GalaxyController : ControllerBase
{
    private readonly IGalaxyRepository _galaxyRepository;
    
    public GalaxyController(IGalaxyRepository galaxyRepository)
    {
        _galaxyRepository = galaxyRepository;
    }

    [HttpGet("GetGalaxies")]
    public async Task<ActionResult> GetGalaxies()
    {
        try
        {
            return Ok(await _galaxyRepository.GetGalaxies());
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
        }
    }
    
    [HttpGet($"GetStars/{{id:int}}")]
    public async Task<ActionResult> GetStarsByGalaxyId(int id)
    {
        try
        {
            return Ok(await _galaxyRepository.GetStarsByGalaxyId(id));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
        }
    }
}