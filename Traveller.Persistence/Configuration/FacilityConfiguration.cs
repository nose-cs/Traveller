using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class FacilityConfiguration : EntityConfiguration<Facility>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Facility> builder)
    {
    }
}