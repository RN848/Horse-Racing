using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models;

public class DeliveryRequest
{
    [Key]
    public int RequestId { get; set; }
    
    public int RequesterId { get; set; }
    [ForeignKey("RequesterId")]
    public Staff Staff { get; set; } = null!;

    [Required, MaxLength(10)]
    public string OriginRoomId { get; set; } = null!;
    [ForeignKey("OriginRoomId")]
    public Location Origin { get; set; } = null!;

    [Required, MaxLength(10)]
    public string DestinationRoomId { get; set; } = null!;
    [ForeignKey("DestinationRoomId")]
    public Location Destination { get; set; } = null!;

    public DateTime RequestTime { get; set; } = DateTime.Now;
    
    [MaxLength(20)]
    public string Status { get; set; } = "Waiting"; // Default status
    
    public DateTime? ArrivalTime { get; set; } // Null until the robot reaches

    public ICollection<Sample> Samples { get; set; } = new List<Sample>();
}