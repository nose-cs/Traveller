using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class TourConfiguration : EntityConfiguration<Tour>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Tour> builder)
    {
        builder
            .UseTphMappingStrategy()
            .HasDiscriminator();
    }
}

public class ExtendedTourConfiguration : EntityConfiguration<ExtendedTour>
{
    protected override bool ConfigureKey => false;

    protected override void ConfigureEntity(EntityTypeBuilder<ExtendedTour> builder)
    {
    }
}