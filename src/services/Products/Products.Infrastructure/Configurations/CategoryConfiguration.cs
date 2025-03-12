using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domin.Entities;
using Products.Infrastructure.SeedData;
using System.Text.Json;

namespace Products.Infrastructure.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
        builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
        builder.Property(p => p.BannerUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://via.placeholder.com/500x100.png");
        builder.Property(p => p.IconUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://via.placeholder.com/85.png");
        builder.Property(p => p.ThumbnailUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://via.placeholder.com/150.png");
        builder.Property(p => p.CreationDateTime).IsRequired().HasDefaultValueSql("CURRENT_TIMESTAMP");
        builder.Property(p => p.ModificationDateTime).IsRequired(false);
        //builder.HasData(GenerateFakeData.SeedFakeCategory());


        builder.HasMany(x => x.Products)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.ParentCategory)
            .WithMany(x => x.Children)
            .HasForeignKey(x => x.ParentCategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }

}
