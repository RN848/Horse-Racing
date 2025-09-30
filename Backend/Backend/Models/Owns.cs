using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models;

public class Owns
{
    [MaxLength(15)]
    [Required]
    public string OwnerId { get; set; } = null!;

    [MaxLength(15)]
    [Required]
    public string HorseId { get; set; } = null!;

    // Navigation
    [ForeignKey(nameof(OwnerId))]
    public Owner Owner { get; set; } = null!;

    [ForeignKey(nameof(HorseId))]
    public Horse Horse { get; set; } = null!;
    
    
    // how to set composite key in EF Core?
    
}