using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class FlightReservationConfiguration : EntityConfiguration<FlightReservation>
{
    protected override void ConfigureEntity(EntityTypeBuilder<FlightReservation> builder)
    {
        builder.HasOne(fr => fr.Tourist).WithMany(t => t.FlightReservations).HasForeignKey(fr => fr.TouristId);
        builder.HasOne(fr => fr.Offer).WithMany(o => o.Reservations).HasForeignKey(fr => fr.OfferId);
        builder.HasOne(fr => fr.Payment).WithOne();
    }
}