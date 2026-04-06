namespace Backend.Dtos;

public class TransitRequestDto
{
    public int RequestId { get; set; }
    public string OriginRoomId { get; set; } = null!;
    public string DestinationRoomId { get; set; } = null!;
    public string Status { get; set; } = null!;
    public DateTime RequestTime { get; set; }
    // Notice we only send the Sample ID and Type, not the whole Sample object!
    public List<SampleSummaryDto> Samples { get; set; } = new();
}