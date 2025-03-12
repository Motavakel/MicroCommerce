using Microsoft.EntityFrameworkCore;
using Products.Domin.Entities;
using Products.Infrastructure.Configurations;

namespace Products.Infrastructure.Persistence.Context;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
    }
}
