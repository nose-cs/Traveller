﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class PackageConfiguration : EntityConfiguration<Package>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Package> builder)
    {
        builder.ToTable("Packages");
        builder.HasOne(o => o.Agency).WithMany(a => a.Packages).HasForeignKey(o => o.AgencyId);
        builder.HasMany(o => o.Reservations).WithOne(r => r.Offer);
        builder.HasOne(o => o.Image).WithMany();
    }
}