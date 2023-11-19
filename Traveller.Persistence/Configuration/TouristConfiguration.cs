using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class TouristConfiguration : EntityConfiguration<Tourist>
{
    protected override bool ConfigureKey => false;

    protected override void ConfigureEntity(EntityTypeBuilder<Tourist> builder)
    {
        builder.HasIndex(t => t.Country);
        builder.UseTptMappingStrategy();
    }
}