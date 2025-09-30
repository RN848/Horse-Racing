using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Owner
{
    [Key]
    [MaxLength(15)]
    [Required]
    public string OwnerId { get; set; } = null!;

    [MaxLength(15)]
    public string? LName { get; set; }

    [MaxLength(15)]
    public string? FName { get; set; }

    // Navigation
    public ICollection<Horse> Horses { get; set; } = new List<Horse>();
    
    public ICollection<Owns> Owns { get; set; } = new List<Owns>();
}