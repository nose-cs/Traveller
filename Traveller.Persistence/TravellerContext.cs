using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Models;

namespace Traveller.Persistence;

public class TravellerContext : DbContext
{
    public TravellerContext(DbContextOptions<TravellerContext> options) : base(options)
    {
    }
    public DbSet<Agency> Agencies { get; set; } = null!;
    
    public DbSet<Flight> Flights { get; set; } = null!;
    public DbSet<FlightOffer> FlightOffers { get; set; } = null!;
    public DbSet<FlightReservation> FlightReservations { get; set; } = null!;
    public DbSet<Hotel> Hotels { get; set; } = null!;
    public DbSet<HotelOffer> HotelOffers { get; set; } = null!;
    public DbSet<HotelReservation> HotelReservations { get; set; } = null!;
    public DbSet<Tour> Tours { get; set; } = null!;
    public DbSet<TourOffer> TourOffers { get; set; } = null!;
    public DbSet<TourReservation> TourReservations { get; set; } = null!;
    public DbSet<Package> Packages { get; set; } = null!;
    public DbSet<PackageOffer> PackageOffers { get; set; } = null!;
    public DbSet<Facility> Facilities { get; set; } = null!;
    public DbSet<PackageFacility> PackageFacility { get; set; } = null!;
    public DbSet<PackageReservation> PackageReservations { get; set; } = null!;
    public DbSet<Payment> Payment { get; set; } = null!;
    
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Tourist> Tourists { get; set; } = null!;
    public DbSet<AgencyUser> AgencyUsers { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TravellerContext).Assembly);
    }
}