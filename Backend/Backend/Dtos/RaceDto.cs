namespace Backend.Dtos;

public class RaceDto
{
    public string? RaceId { get; set; }

    public string? RaceName { get; set; }

    public string? TrackName { get; set; }

    public DateTime? RaceDate { get; set; }

    public TimeSpan? RaceTime { get; set; }

    public TrackDto? Track { get; set;}

    public IEnumerable<RaceResultDto> RaceResults { get; set; } = Array.Empty<RaceResultDto>();
}