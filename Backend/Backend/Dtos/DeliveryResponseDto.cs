namespace Backend.Dtos;

public class DeliveryResponseDto
{
    public int RequestId { get; set; }
    public string OriginRoomId { get; set; } = null!;
    public string DestinationRoomId { get; set; } = null!;
    public string Status { get; set; } = null!;
    public DateTime RequestTime { get; set; }
    public DateTime? ArrivalTime { get; set; }
    public List<SampleDto> Samples { get; set; } = new();
}