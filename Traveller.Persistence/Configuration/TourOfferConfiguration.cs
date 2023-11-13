using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class TourOfferConfiguration : EntityConfiguration<TourOffer>
{
    protected override void ConfigureEntity(EntityTypeBuilder<TourOffer> builder)
    {
        builder.HasOne(o => o.Product).WithMany().HasForeignKey(o => o.ProductId);
        builder.HasOne(o => o.Agency).WithMany(a => a.Tours).HasForeignKey(o => o.AgencyId);
        builder.HasMany(o => o.Reservations).WithOne(r => r.Offer);
    }
}