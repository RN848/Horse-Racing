using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models;

public class Trainer
{
    [Key]
    [MaxLength(15)]
    [Required]
    public string TrainerId { get; set; } = null!;

    [MaxLength(30)]
    public string? LName { get; set; }

    [MaxLength(30)]
    public string? FName { get; set; }

    [MaxLength(30)] // DDL says 30, but Stable.StableId is 15 -> better to align both at 15
    public string? StableId { get; set; }

    // Navigation
    [ForeignKey(nameof(StableId))]
    public Stable? Stable { get; set; }
}