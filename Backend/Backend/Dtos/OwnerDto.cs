namespace Backend.Dtos;

public class OwnerDto
{
    
    public string OwnerId { get; set; }

    public string? LName { get; set; }

    public string? FName { get; set; }

    public ICollection<HorseDto> Horses { get; set; } = Array.Empty<HorseDto>();
    
}