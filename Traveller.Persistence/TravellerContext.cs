using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Models;

namespace Traveller.Persistence;

public class TravellerContext : DbContext
{
    public TravellerContext(DbContextOptions<TravellerContext> options) : base(options)
    {
    }
    
    public DbSet<Facility> Facilities { get; set; } = null!;
    public DbSet<PackageFacility> PackageFacility { get; set; } = null!;
    public DbSet<Flight> Flights { get; set; } = null!;
    public DbSet<Hotel> Hotels { get; set; } = null!;
    public DbSet<Tour> Tours { get; set; } = null!;
    public DbSet<Package> Packages { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Facility>().HasKey(e => e.Id);
        modelBuilder.Entity<Package>().HasKey(e => e.Id);

        modelBuilder.Entity<PackageFacility>().Property(pf => pf.PackageId).IsRequired();
        
        modelBuilder.Entity<PackageFacility>()
            .HasOne(pf => pf.Facility)
            .WithMany()
            .HasForeignKey(pf => pf.FacilityId).HasPrincipalKey(f => f.Id).IsRequired();
        
        modelBuilder.Entity<PackageFacility>()
            .HasOne(pf => pf.Package)
            .WithMany()
            .HasForeignKey(pf => pf.PackageId).IsRequired();
        
        modelBuilder.Entity<PackageFacility>()
            .HasKey(pf => new { pf.FacilityId, pf.PackageId })
            .HasName("PK_PackageFacility");
    }
}