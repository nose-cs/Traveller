using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class FlightOfferConfiguration : EntityConfiguration<FlightOffer>
{
    protected override void ConfigureEntity(EntityTypeBuilder<FlightOffer> builder)
    {
        builder.HasOne(o => o.Product).WithMany().HasForeignKey(o => o.ProductId);
        builder.HasOne(o => o.Agency).WithMany(a => a.Flights).HasForeignKey(o => o.AgencyId);
        builder.HasMany(o => o.Reservations).WithOne(r => r.Offer);
    }
}