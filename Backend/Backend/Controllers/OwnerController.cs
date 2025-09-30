using AutoMapper;
using Backend.Data;
using Backend.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;


[ApiController]
[Route("api/[controller]")]
public class OwnerController : ControllerBase
{
    private readonly DbContextApp _dbContext;
    private readonly IMapper _mapper;
    public OwnerController(DbContextApp dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }   
    
    [HttpDelete("{ownerId}")]
    public IActionResult DeleteOwner(string ownerId)
    {
        
        
        var exists = _dbContext.Owners.Any(o => o.OwnerId == ownerId);
        if (!exists) return NotFound();

        // call the procedure (await it!)
        _dbContext.Database.ExecuteSqlRawAsync(
            "CALL DeleteOwnerAndRelated({0})", ownerId);
        
        // // (Optional) short-circuit if not found
        // var owner =  _dbContext.Owners.Find(ownerId);
        // if (owner is null) return NotFound();
        //
        //
        //
        // _dbContext.Owners.Remove(owner);
        // _dbContext.SaveChanges();
        
        return NoContent();
    }
    
    [HttpGet("{LName}")]
    public IActionResult GetOwnerByLastName(string LName)
    {
        
        var owner = _dbContext.Owners
            .Where(o => o.LName == LName)
            .Include(x => x.Horses)
            .ThenInclude(h => h.Stable)
            .ThenInclude(s => s.Trainers)
            .SelectMany(o => o.Horses, (o, h) => new { o, h })
            .SelectMany(oh => oh.h.Stable.Trainers, (oh, t) => new OwnerHorseTrainerDto()
            {
                OwnerId = oh.o.OwnerId,
                LName = oh.o.LName,
                FName = oh.o.FName,
                HorseName = oh.h.HorseName,
                Age = oh.h.Age,
                TrainerLastName = t.LName,
                TrainerFirstName = t.FName
            })
            .ToList();
        
        if (!owner.Any()) return NotFound();
        
        return Ok(owner);


    }

    

}