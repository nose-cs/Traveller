using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class TourReservationConfiguration : EntityConfiguration<TourReservation>
{
    protected override void ConfigureEntity(EntityTypeBuilder<TourReservation> builder)
    {
        builder.HasOne(tr => tr.Tourist).WithMany(t => t.TourReservations).HasForeignKey(fr => fr.TouristId);
        builder.HasOne(tr => tr.Offer).WithMany(o => o.Reservations).HasForeignKey(fr => fr.OfferId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(tr => tr.Payment).WithOne();
    }
}