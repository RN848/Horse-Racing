using AutoMapper;
using Backend.Data;
using Backend.Dtos;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RaceController : ControllerBase
{
    
    private readonly DbContextApp _dbContext;
    private readonly IMapper _mapper;
    public RaceController(DbContextApp dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }   
    
    [HttpGet("{raceId}")]   
    public IActionResult GetRace(string raceId)
    {
        var race = _dbContext.Races
            .Include(r => r.RaceResults)
            .FirstOrDefault(r => r.RaceId == raceId);
            
        if (race == null) return NotFound();
            
        var dto = _mapper.Map<RaceDto>(race);        
        
        return Ok(dto);
    }
    
    [HttpPost()]   
    public IActionResult AddResult([FromBody] RaceDto raceDto)
    {
        
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var race = _mapper.Map<Race>(raceDto);
        _dbContext.Races.Add(race);
        _dbContext.SaveChanges();

        var result = _mapper.Map<RaceDto>(race);
        
        return CreatedAtAction(nameof(AddResult), new { raceId = race.RaceId }, result);
    }
    
    [HttpGet("tracks-stats")]   
    public IActionResult tracksStats()
    {
        var tracks = _dbContext.Tracks
            .Include(t => t.Races)
            .ThenInclude(r => r.RaceResults)
            .ThenInclude(rr => rr.Horse)
            .Select(t => new
            {
                trackname = t.TrackName,
                racesnumber = t.Races.Count(),
                horsesnumber = t.Races
                    .SelectMany(r => r.RaceResults)
                    .Select(rr => rr.HorseId)
                    .Distinct()
                    .Count()

            })
            .ToList();
            
            
        if (tracks.Count() == 0) return NotFound();
            
        var dto = (tracks);        
        
        return Ok(dto);
    }
    
}