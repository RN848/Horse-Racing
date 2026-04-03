namespace Backend.Dtos;

public class CreateDeliveryDto
{
    public string OriginRoomId { get; set; } = null!;
    public string DestinationRoomId { get; set; } = null!;
    public int StaffId { get; set; } // Usually from the logged-in user
    public List<SampleDto> Samples { get; set; } = new();
}