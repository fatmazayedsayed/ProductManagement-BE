using Microsoft.EntityFrameworkCore;
using ProductManagement.Common.Enum;
using ProductManagement.Domain.Models;

namespace ProductManagement.Infrastructure
{

    public static class DataSeeding
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {

            //seed Admin User

            modelBuilder.Entity<User>().HasData(
               new User
               {
                   Id = Guid.NewGuid(),
                   UserName = "admin",
                   Email = "Admin@urwave.com",
                   IsActive = true,
                   UserType=UserType.Admin,
                   Password = "f99c5521e65bcf281a101f9aa73351179c8e4daf"//admin
               });

            // Seed Categories
            var electronicsCategoryId = Guid.NewGuid();
            var clothingCategoryId = Guid.NewGuid();
            var groceriesCategoryId = Guid.NewGuid();

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = electronicsCategoryId,
                    Name = "Electronics",
                    Description = "Devices and gadgets"
                },
                new Category
                {
                    Id = clothingCategoryId,
                    Name = "Clothing",
                    Description = "Men's and Women's apparel"
                },
                new Category
                {
                    Id = groceriesCategoryId,
                    Name = "Groceries",
                    Description = "Daily essentials and food items"
                }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Smartphone",
                    Description = "Latest model smartphone",
                    Price = 699.99m,
                    StockQuantity = 50,
                    Status = ProductStatus.Active,
                    CategoryId = electronicsCategoryId
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "T-Shirt",
                    Description = "Cotton T-shirt",
                    Price = 19.99m,
                    StockQuantity = 200,
                    Status = ProductStatus.Active,
                    CategoryId = clothingCategoryId
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Pasta",
                    Description = "Organic pasta",
                    Price = 4.99m,
                    StockQuantity = 100,
                    Status = ProductStatus.Active,
                    CategoryId = groceriesCategoryId
                }
            );
        }
    }

}
