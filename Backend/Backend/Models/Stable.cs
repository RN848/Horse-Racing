using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Stable
{
    [Key]
    [MaxLength(15)]
    [Required]
    public string StableId { get; set; } = null!;

    [MaxLength(30)]
    public string? StableName { get; set; }

    [MaxLength(30)]
    public string? Location { get; set; }

    [MaxLength(20)]
    public string? Colors { get; set; }

    public ICollection<Horse> Horses { get; set; } = new List<Horse>();
    public ICollection<Trainer> Trainers { get; set; } = new List<Trainer>();    
}