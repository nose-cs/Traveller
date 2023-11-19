using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class PlaceConfiguration : EntityConfiguration<Place>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Place> builder)
    {
        builder.Property(p => p.Address).IsRequired();
        builder.HasIndex(p => p.City);
        builder.Property(p => p.City).IsRequired();
        builder.HasIndex(p => p.Country);
        builder.Property(p => p.Country).IsRequired();
    }
}