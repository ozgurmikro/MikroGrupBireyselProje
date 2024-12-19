using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikroGrupBireyselProje.Order.Domain.Entities;

namespace MikroGrupBireyselProje.Order.Repository.Configuration;

internal class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.District).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Line).IsRequired().HasMaxLength(500);
        builder.Property(x => x.Province).IsRequired().HasMaxLength(100);
        builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(100);
    }
}