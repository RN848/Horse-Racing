namespace Backend.Dtos;

public class DeliveryHistoryDto
{
    public int RequestId { get; set; }
    public string OriginRoom { get; set; } = null!;
    public string DestinationRoom { get; set; } = null!;
    public DateTime Time { get; set; }
    public List<string> SampleIds { get; set; } = new();
}