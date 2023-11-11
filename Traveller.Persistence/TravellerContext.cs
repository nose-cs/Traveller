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
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TravellerContext).Assembly);
    }
}