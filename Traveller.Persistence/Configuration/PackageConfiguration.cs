﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Configuration;

public class PackageConfiguration : EntityConfiguration<Package>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Package> builder)
    {
    }
}