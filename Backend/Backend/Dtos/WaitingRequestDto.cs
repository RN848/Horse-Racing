namespace Backend.Dtos;

public class WaitingRequestDto
{
    public int RequestId { get; set; }
    public string OriginRoomId { get; set; } = null!;
    public string DestinationRoomId { get; set; } = null!;
    public string Status { get; set; } = null!;
    public List<SampleSummaryDto> Samples { get; set; } = new();
}