using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models;

public class Sample
{
    [Key, MaxLength(50)]
    public string SampleUniqueId { get; set; } = null!;

    public int RequestId { get; set; }
    [ForeignKey("RequestId")]
    public DeliveryRequest DeliveryRequest { get; set; } = null!;

    [MaxLength(50)]
    public string? SampleType { get; set; }
}