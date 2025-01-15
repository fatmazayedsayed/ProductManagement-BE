using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductManagement.Common.Enum;
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


    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Product> Product { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data
        modelBuilder.SeedData();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
