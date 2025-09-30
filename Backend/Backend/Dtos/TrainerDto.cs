using System.ComponentModel.DataAnnotations.Schema;
using Backend.Models;

namespace Backend.Dtos;

public class TrainerDto
{
    
    public string TrainerId { get; set; }

    public string? LName { get; set; }

    public string? FName { get; set; }

    public string? StableId { get; set; }

    public StableDto? Stable { get; set; }
}