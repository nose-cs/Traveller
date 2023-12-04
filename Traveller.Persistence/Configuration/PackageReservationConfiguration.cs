using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class PackageReservationConfiguration : EntityConfiguration<PackageReservation>
{
    protected override void ConfigureEntity(EntityTypeBuilder<PackageReservation> builder)
    {
        builder.HasOne(pr => pr.Tourist).WithMany(t => t.PackageReservations).HasForeignKey(fr => fr.TouristId);
        builder.HasOne(pr => pr.Offer).WithMany(o => o.Reservations).HasForeignKey(fr => fr.OfferId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(pr => pr.Payment).WithOne();
    }
}