using Backend.Models;

namespace Backend.Dtos;

public class RaceResultDto
{
    
    public string? RaceId { get; set; }
    
    public string? HorseId { get; set; }

    public string? Results { get; set; }

    public float? Prize { get; set; }

}