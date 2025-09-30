namespace Backend.Dtos;

public class WinningTrainerDto
{
    public TrainerDto? Trainer { get; set; }
    public HorseDto? Horse { get; set; }
    public RaceDto? Race { get; set; }
}