using Backend.Models;

namespace Backend.Dtos;

public class TrackDto
{
    public string TrackName { get; set; }

    public string? Location { get; set; }

    public int? Length { get; set; }

    public IEnumerable<RaceDto> Races { get; set; } = Array.Empty<RaceDto>();
}