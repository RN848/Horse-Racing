using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Backend.Models;


public class Staff
{
    [Key]
    public int StaffId { get; set; }
    [Required, MaxLength(100)]
    public string FullName { get; set; } = null!;
    
    
    [Required, MaxLength(50)]
    public string Username { get; set; } = null!; // Added for login
    
    [Required, MaxLength(100)]
    public string Password { get; set; } = null!; // Added for login
    
    [MaxLength(50)]
    public string? JobTitle { get; set; }
    [MaxLength(50)]
    public string? Department { get; set; }

    // Navigation property
    public ICollection<DeliveryRequest> DeliveryRequests { get; set; } = new List<DeliveryRequest>();
}