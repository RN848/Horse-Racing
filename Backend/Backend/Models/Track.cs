using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Track
{
    [Key]
    [MaxLength(30)]
    [Required]
    public string TrackName { get; set; } = null!;

    [MaxLength(30)]
    public string? Location { get; set; }

    public int? Length { get; set; }

    // Navigation
    public ICollection<Race> Races { get; set; } = new List<Race>();

}