using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Data;

public class DbContextApp : DbContext
{
    
    public DbContextApp(DbContextOptions<DbContextApp> options) : base(options)
    {
    }
    
    public DbSet<Staff> Staffs { get; set; } = null!;
    public DbSet<Location> Locations { get; set; } = null!;
    public DbSet<DeliveryRequest> DeliveryRequests { get; set; } = null!;
    public DbSet<Sample> Samples { get; set; } = null!;

    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        
        // Configure Table Names to match your SQL exactly
        modelBuilder.Entity<Staff>().ToTable("staff");
        modelBuilder.Entity<Location>().ToTable("location");
        modelBuilder.Entity<DeliveryRequest>().ToTable("delivery_request");
        modelBuilder.Entity<Sample>().ToTable("sample");

        // Set up the Relationship for Origin Room
        modelBuilder.Entity<DeliveryRequest>()
            .HasOne(d => d.Origin)
            .WithMany(l => l.OriginRequests)
            .HasForeignKey(d => d.OriginRoomId)
            .OnDelete(DeleteBehavior.Restrict); // Prevents accidental deletion cycles

        // Set up the Relationship for Destination Room
        modelBuilder.Entity<DeliveryRequest>()
            .HasOne(d => d.Destination)
            .WithMany(l => l.DestinationRequests)
            .HasForeignKey(d => d.DestinationRoomId)
            .OnDelete(DeleteBehavior.Restrict);

        // Default value for RequestTime
        modelBuilder.Entity<DeliveryRequest>()
            .HasOne(d => d.Destination)
            .WithMany(l => l.DestinationRequests)
            .HasForeignKey(d => d.DestinationRoomId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Location>().HasData(
            new Location { RoomId = "A-101", Description = "Emergency Room" },
            new Location { RoomId = "LAB-05", Description = "Pathology Lab" }
        );
        
        modelBuilder.Entity<Staff>().HasData(
            new Staff { StaffId = 1, Username = "fdsfdsf" , Password = "1234" ,FullName = "Rayan Robot-Operator", JobTitle = "Technician" }
        );


    }






}