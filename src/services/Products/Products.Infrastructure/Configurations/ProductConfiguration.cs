using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domin.Entities;
using Products.Infrastructure.SeedData;

namespace Products.Infrastructure.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
        builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
        builder.Property(p => p.CoverImageUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://via.placeholder.com/150x150.png");
        builder.Property(p => p.CreationDateTime).IsRequired().HasDefaultValueSql("CURRENT_TIMESTAMP");
        builder.Property(p => p.ModificationDateTime).IsRequired(false);
        builder.HasData(GenerateFakeData.SeedFakeProduct());


        builder.HasOne(p => p.Category)
            .WithMany(p => p.Products)
            .HasForeignKey(x => x.CategoryId);
    }
}