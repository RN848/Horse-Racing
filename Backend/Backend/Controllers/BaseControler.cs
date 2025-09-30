using AutoMapper;
using Backend.Data;
using Backend.Dtos;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    
    
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        
        // dbcontext
        private DbContextApp _dbContext;
        private IMapper _mapper;
        public BaseController(DbContextApp dbContext , IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        
        [HttpGet("horses/{id}")]
        public IActionResult GetHorse(string id)
        {
            var horse = _dbContext.Horses
                .Include(h => h.RaceResults)
                .FirstOrDefault(h => h.HorseId == id);
            
            if (horse == null) return NotFound();
            
            var dto = _mapper.Map<HorseDto>(horse);
            
            return Ok(dto);
        }
        
        
        
        [HttpPost("races")]
        public IActionResult AddRase([FromBody] RaceDto race)
        {
            return Ok(race);
        }
    }
}