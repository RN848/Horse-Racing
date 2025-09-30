using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models;

public class Race
{
    [Key]
    [MaxLength(15)]
    [Required]
    public string RaceId { get; set; } = null!;

    [MaxLength(30)]
    public string? RaceName { get; set; }

    [MaxLength(30)]
    public string? TrackName { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RaceDate { get; set; }

    [Column(TypeName = "time")]
    public TimeSpan? RaceTime { get; set; }

    // Navigation
    [ForeignKey(nameof(TrackName))]
    public Track? Track { get; set; }

    public ICollection<RaceResults> RaceResults { get; set; } = new List<RaceResults>();
}