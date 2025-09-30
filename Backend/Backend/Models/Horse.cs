using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public enum Gender
{
    F, // filly
    C, // colt
    M, // mare
    S, // stallion
    G  // gelding
}

public class Horse
{
    [Key]
    [MaxLength(15)]
    [Required]
    public string HorseId { get; set; } = null!;

    [Required]
    [MaxLength(15)]
    public string HorseName { get; set; } = null!;

    public int? Age { get; set; }

    // Stored as CHAR(1) in DB — will need Fluent config for enum conversion
    public Gender? Gender { get; set; }

    [Required]
    public int Registration { get; set; }

    [Required]
    [MaxLength(30)]  // matches your DDL here (note: Stable.StableId is 15 chars, so could adjust)
    public string StableId { get; set; } = null!;

    // Navigation
    public Stable Stable { get; set; } = null!;
    
    public ICollection<Owner> Owners { get; set; } = new List<Owner>();
    public ICollection<RaceResults> RaceResults { get; set; } = new List<RaceResults>();
    
    public ICollection<Owns> Owns { get; set; } = new List<Owns>();

}