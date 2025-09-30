using AutoMapper;
using Backend.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HorseController : ControllerBase
{
    private readonly DbContextApp _dbContext;
    private readonly IMapper _mapper;
    public HorseController(DbContextApp dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    [HttpPut("{horseId}")]
    public IActionResult ChangeStable(string horseId, [FromQuery] string newStableId)
    {
        var horse = _dbContext.Horses.Find(horseId);
        if (horse is null) return NotFound();

        horse.StableId = newStableId;   
        _dbContext.SaveChanges();

        return NoContent();
    }
    
}