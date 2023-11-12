using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class UserConfiguration : EntityConfiguration<User>
{
    protected override void ConfigureEntity(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Role).HasConversion<string>();
        builder.HasIndex(u => u.Role);

        builder.HasIndex(u => u.Email).IsUnique();

        builder.UseTptMappingStrategy();
    }
}