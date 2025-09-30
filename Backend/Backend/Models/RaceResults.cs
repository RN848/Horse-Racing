using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public class RaceResults
{
    [MaxLength(15)]
    [Required]
    public string RaceId { get; set; } = null!;

    [MaxLength(15)]
    [Required]
    public string HorseId { get; set; } = null!;

    [MaxLength(15)]
    public string? Results { get; set; }

    [Precision(10, 2)] // EF Core 7+ (maps to FLOAT(10,2) / DECIMAL(10,2))
    public float? Prize { get; set; }

    // Navigation
    [ForeignKey(nameof(RaceId))]
    public Race Race { get; set; } = null!;

    [ForeignKey(nameof(HorseId))]
    public Horse Horse { get; set; } = null!;
    
}