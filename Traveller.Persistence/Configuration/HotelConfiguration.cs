using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class HotelConfiguration : EntityConfiguration<Hotel>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Hotel> builder)
    {
        builder.HasMany<ExtendedTour>().WithMany(et => et.Hotels);
    }
}