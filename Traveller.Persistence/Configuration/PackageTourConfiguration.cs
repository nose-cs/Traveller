using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class PackageTourConfiguration : IEntityTypeConfiguration<PackageTour>
{
    public void Configure(EntityTypeBuilder<PackageTour> builder)
    {
        builder
            .HasOne(x => x.Tour)
            .WithMany(x => x.Packages)
            .HasForeignKey(x => x.TourId).IsRequired();
        
        builder
            .HasOne(pf => pf.Package)
            .WithMany(p => p.Tours)
            .HasForeignKey(pf => pf.PackageId).IsRequired();
        
        builder.HasKey(pt => new { pt.TourId, pt.PackageId }).HasName("PK_PackageTour");
    }
}