using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class PackageOfferConfiguration : EntityConfiguration<PackageOffer>
{
    protected override void ConfigureEntity(EntityTypeBuilder<PackageOffer> builder)
    {
        builder.HasOne(o => o.Product).WithMany().HasForeignKey(o => o.ProductId);
        builder.HasOne(o => o.Agency).WithMany(a => a.Packages).HasForeignKey(o => o.AgencyId);
        builder.HasMany(o => o.Reservations).WithOne(r => r.Offer);
    }
}