using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain;

namespace Traveller.Persistence.Configuration;

public abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IDbModel
{
    protected virtual bool ConfigureKey => true;

    public void Configure(EntityTypeBuilder<T> builder)
    {
        if (ConfigureKey)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }

        ConfigureEntity(builder);
    }

    protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
}