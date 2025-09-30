using AutoMapper;
using Backend.Data;
using Backend.Dtos;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RaceResultsController : ControllerBase
{
    
    private readonly DbContextApp _dbContext;
    private readonly IMapper _mapper;
    public RaceResultsController(DbContextApp dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }   
    
    [HttpGet("{raceId}")]   
    public IActionResult GetRaceResults(string raceId)
    {
        var raceResults = _dbContext.RaceResults
            .Where(rr => rr.RaceId == raceId) 
            .ToList();
            
        if (raceResults == null) return NotFound();
            
        var dtoList = _mapper.Map<List<RaceResultDto>>(raceResults);        
        
        
        return Ok(dtoList);
    }
    
    

}