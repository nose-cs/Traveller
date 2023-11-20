using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class PaymentConfiguration : EntityConfiguration<Payment>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payments");
        builder.UseTphMappingStrategy();
    }
}

public class PaymentByCardConfiguration : EntityConfiguration<PaymentByCard>
{
    protected override bool ConfigureKey => false;

    protected override void ConfigureEntity(EntityTypeBuilder<PaymentByCard> builder)
    {
        builder.UseTphMappingStrategy();
    }
}