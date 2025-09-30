namespace Backend.Dtos;

public class OwnerHorseTrainerDto
{
    public string OwnerId { get; set; } = null!;
    public string? LName { get; set; }
    public string? FName { get; set; }
    
    public string HorseName { get; set; } = null!;
    public int? Age { get; set; }
    
    public string TrainerFirstName { get; set; } = null!;
    public string TrainerLastName { get; set; } = null!;
}