namespace Backend.Dtos;

public class HorseDto
{
    public string HorseId { get; set; } = null!;
    public string HorseName { get; set; } = null!;
    public int? Age { get; set; }
    public string? Gender { get; set; }          // optional: "F","C","M","S","G" or full name if you prefer
    public IEnumerable<RaceResultDto> RaceResults { get; set; } = Array.Empty<RaceResultDto>();
}