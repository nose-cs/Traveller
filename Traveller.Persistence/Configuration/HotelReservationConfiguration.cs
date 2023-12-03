using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class HotelReservationConfiguration : EntityConfiguration<HotelReservation>
{
    protected override void ConfigureEntity(EntityTypeBuilder<HotelReservation> builder)
    {
        builder.HasOne(hr => hr.Tourist).WithMany(t => t.HotelReservations).HasForeignKey(fr => fr.TouristId);
        builder.HasOne(hr => hr.Offer).WithMany(o => o.Reservations).HasForeignKey(fr => fr.OfferId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(hr => hr.Payment).WithOne();
    }
}