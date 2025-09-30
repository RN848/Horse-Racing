using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Data;

public class DbContextApp : DbContext
{
    
    public DbContextApp(DbContextOptions<DbContextApp> options) : base(options)
    {
    }
    
    public DbSet<Horse> Horses { get; set; } = null!;
    public DbSet<Owner> Owners { get; set; } = null!;
    public DbSet<Owns> Owns { get; set; } = null!;
    public DbSet<Race> Races { get; set; } = null!;
    public DbSet<RaceResults> RaceResults { get; set; } = null!;
    public DbSet<Stable> Stables { get; set; } = null!;
    public DbSet<Track> Tracks { get; set; } = null!;
    public DbSet<Trainer> Trainers { get; set; } = null!;

    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        
        // Horse.Gender
        
        var genderConverter = new ValueConverter<Gender?, string>(
            v => v.HasValue ? v.Value.ToString().Substring(0, 1) : null,   // Enum → "F", "C", ...
            v => string.IsNullOrEmpty(v) ? null : Enum.Parse<Gender>(v, true) // "F" → Gender.F
        );

        modelBuilder.Entity<Horse>(entity =>
        {
            entity.Property(h => h.Gender)
                .HasConversion(genderConverter)  // convert enum <-> char(1)
                .HasMaxLength(1)
                .HasColumnType("char(1)");    // ensures CHAR(1) instead of VARCHAR(1)
        });
        
        
        // Owns Composite keys
        
        modelBuilder.Entity<Owns>()
            .HasKey(o => new { o.OwnerId, o.HorseId });
        
        modelBuilder.Entity<Owner>()
            .HasMany(o => o.Horses)
            .WithMany(h => h.Owners)
            .UsingEntity<Owns>(
                j => j.HasOne(x => x.Horse).WithMany(h => h.Owns).HasForeignKey(x => x.HorseId),
                j => j.HasOne(x => x.Owner).WithMany(o => o.Owns).HasForeignKey(x => x.OwnerId),
                j => j.ToTable("Owns")
            );
        
        // RaceResults Composite keys
        
        modelBuilder.Entity<RaceResults>()
            .HasKey(rr => new { rr.RaceId, rr.HorseId });
        
        modelBuilder.Entity<Stable>().HasData(SeedData.Stables);
        modelBuilder.Entity<Horse>().HasData(SeedData.Horses);
        modelBuilder.Entity<Owner>().HasData(SeedData.Owners);
        modelBuilder.Entity<Owns>().HasData(SeedData.Owns);
        modelBuilder.Entity<Trainer>().HasData(SeedData.Trainers);
        modelBuilder.Entity<Track>().HasData(SeedData.Tracks);
        modelBuilder.Entity<Race>().HasData(SeedData.Races);
        modelBuilder.Entity<RaceResults>().HasData(SeedData.RaceResults);
        
        
    }






}