using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class FlightConfiguration : EntityConfiguration<Flight>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Flight> builder)
    {
    }
}