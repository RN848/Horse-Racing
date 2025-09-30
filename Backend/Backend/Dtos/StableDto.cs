using Backend.Models;

namespace Backend.Dtos;

public class StableDto
{
    
    public string StableId { get; set; }
    
    public string? StableName { get; set; }

    public string? Location { get; set; }

    public string? Colors { get; set; }

    public ICollection<HorseDto> Horses { get; set; } =  Array.Empty<HorseDto>();
    
    public ICollection<TrainerDto> Trainers { get; set; } =  Array.Empty<TrainerDto>();   
    
}