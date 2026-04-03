using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models;

public class Location
{
    [Key, MaxLength(10) ]
    public string RoomId { get; set; } = null!; // Matches room_id in SQL
    public string? Description { get; set; }

    // Navigation properties for origin and destination
    [InverseProperty("Origin")]
    public ICollection<DeliveryRequest> OriginRequests { get; set; } = new List<DeliveryRequest>();
    [InverseProperty("Destination")]
    public ICollection<DeliveryRequest> DestinationRequests { get; set; } = new List<DeliveryRequest>();
}