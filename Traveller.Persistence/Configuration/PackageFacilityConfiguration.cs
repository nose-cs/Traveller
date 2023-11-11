using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class PackageFacilityConfiguration : EntityConfiguration<PackageFacility>
{
    protected override void ConfigureEntity(EntityTypeBuilder<PackageFacility> builder)
    {
        builder
            .HasOne(pf => pf.Facility)
            .WithMany(f => f.Packages)
            .HasForeignKey(pf => pf.FacilityId).HasPrincipalKey(f => f.Id).IsRequired();
        
        builder
            .HasOne(pf => pf.Package)
            .WithMany(p => p.Facilities)
            .HasForeignKey(pf => pf.PackageId).IsRequired();

        builder
            .HasKey(pf => new { pf.FacilityId, pf.PackageId }).HasName("PK_PackageFacility");
    }
}