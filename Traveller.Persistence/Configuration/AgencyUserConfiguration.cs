using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class AgencyUserConfiguration : IEntityTypeConfiguration<AgencyUser>
{
    

    public void Configure(EntityTypeBuilder<AgencyUser> builder)
    {
        builder.HasOne(a => a.Agency).WithMany(a => a.AgencyUsers).HasForeignKey(a => a.AgencyId);
        builder.UseTptMappingStrategy();
    }
}