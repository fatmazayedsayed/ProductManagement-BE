using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Models;

namespace ProductManagement.Infrastructure;

public partial class ProductManagementDbContext : DbContext
{
    public ProductManagementDbContext()
    {
    }

    public ProductManagementDbContext(DbContextOptions<ProductManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Apply global query filter to all entities inheriting from BaseModel
        modelBuilder.Entity<User>()
            .HasQueryFilter(m => !m.IsDeleted);
        modelBuilder.Entity<Category>()
            .HasQueryFilter(m => !m.IsDeleted);
        modelBuilder.Entity<Category>()
            .HasQueryFilter(m => !m.IsDeleted);

        base.OnModelCreating(modelBuilder);

        // Seed data
        modelBuilder.SeedData();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
