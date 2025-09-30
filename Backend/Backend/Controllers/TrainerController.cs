using AutoMapper;
using Backend.Data;
using Backend.Dtos;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TrainerController : ControllerBase
{
    
    private readonly DbContextApp _dbContext;
    private readonly IMapper _mapper;
    public TrainerController(DbContextApp dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
    
    [HttpGet("{trainerId}")]   
    public IActionResult GetRace(string trainerId)
    {
        var trainer = _dbContext.Trainers
            .FirstOrDefault(r => r.TrainerId == trainerId);
            
        if (trainer == null) return NotFound();
            
        var dto = _mapper.Map<TrainerDto>(trainer);        
        
        return Ok(dto);
    }
    
    [HttpPost()]
    public IActionResult addtrainer([FromBody] TrainerDto trainerDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var trainer = _mapper.Map<Trainer>(trainerDto);
        _dbContext.Trainers.Add(trainer);
        _dbContext.SaveChanges();

        var result = _mapper.Map<TrainerDto>(trainer);
        
        return CreatedAtAction(nameof(addtrainer), new { trainerId = trainer.TrainerId }, result);
    } 
    
    [HttpGet("winning-trainers")]
    public IActionResult winngtrainers()
    {

        var winningTrainers = _dbContext.RaceResults
            .Where(rr => rr.Results.ToLower() == "first")
            .Include(rr => rr.Race)
            .Include(rr => rr.Horse)
            .ThenInclude(h => h.Stable)
            .ThenInclude(s => s.Trainers)
            .SelectMany(rr => rr.Horse.Stable.Trainers, ((results, trainer) => new WinningTrainerDto()
            {
                Trainer = new TrainerDto()
                {
                    TrainerId = trainer.TrainerId,
                    FName = trainer.FName,
                    LName = trainer.LName,
                    StableId = trainer.StableId
                },
                
                Horse = _mapper.Map<HorseDto>(results.Horse),
                Race = _mapper.Map<RaceDto>(results.Race)

            }))
            .ToList();
            
        
        if (winningTrainers.Count == 0) return NotFound();
        return Ok(winningTrainers);



    }
    
    [HttpGet("trainer-winnings")]
    public IActionResult trainerWinnings()
    {

        var trainers = _dbContext.Trainers
            .Include(t => t.Stable)
            .ThenInclude(s => s.Horses)
            .ThenInclude(h => h.RaceResults)
            .Select( t => new
            {
                Fname = t.FName,
                Lname = t.LName,
                totalwinnings = t.Stable.Horses
                    .SelectMany(h => h.RaceResults)
                    .Sum(rr => rr.Prize)
            })
            .OrderByDescending(x => x.totalwinnings)
            .ToList();
            
        
        if (trainers.Count == 0) return NotFound();
        return Ok(trainers);

    }
    
   
    

    
}