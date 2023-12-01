using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class TourConfiguration : EntityConfiguration<Tour>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Tour> builder)
    {
        builder.HasOne(t => t.SourcePlace).WithMany(p => p.ToursWithSource).HasForeignKey(t => t.SourcePlaceId);
        builder.HasOne(t => t.DestinationPlace).WithMany(p => p.ToursWithDestination).HasForeignKey(t => t.DestinationPlaceId); 
        builder.Property(t => t.SourceDay).IsRequired();
        builder.Property(t => t.Duration).IsRequired();
        builder.Property(t => t.SourceTime).IsRequired();
        builder.Property(t => t.DestinationTime).IsRequired();
        builder.UseTphMappingStrategy().HasDiscriminator();
    }
}

public class ExtendedTourConfiguration : EntityConfiguration<ExtendedTour>
{
    protected override bool ConfigureKey => false;

    protected override void ConfigureEntity(EntityTypeBuilder<ExtendedTour> builder)
    {
    }
}