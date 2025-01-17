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
            var userId = Guid.NewGuid();
            var insertedDate = DateTime.Now;
            SeedAdmin(userId, insertedDate, modelBuilder);


            // Seed Categories
            var electronicsCategoryId = Guid.NewGuid();
            var clothingCategoryId = Guid.NewGuid();
            var groceriesCategoryId = Guid.NewGuid();

            SeedCategory(userId, insertedDate, modelBuilder, "electronics", electronicsCategoryId,null);

            SeedSubCategory(userId, insertedDate, modelBuilder, "electronics", electronicsCategoryId);

            SeedCategory(userId, insertedDate, modelBuilder, "clothing", clothingCategoryId, null);
            SeedSubCategory(userId, insertedDate, modelBuilder, "clothing", clothingCategoryId);

            SeedCategory(userId, insertedDate, modelBuilder, "groceries", groceriesCategoryId, null);
            SeedSubCategory(userId, insertedDate, modelBuilder, "groceries", groceriesCategoryId);

            // Seed Products
            SeedProduct(userId, insertedDate, modelBuilder, electronicsCategoryId);
            SeedProduct(userId, insertedDate, modelBuilder, electronicsCategoryId);

            SeedProduct(userId, insertedDate, modelBuilder, clothingCategoryId);
            SeedProduct(userId, insertedDate, modelBuilder, clothingCategoryId);

            SeedProduct(userId, insertedDate, modelBuilder, groceriesCategoryId);
            SeedProduct(userId, insertedDate, modelBuilder, groceriesCategoryId);




        }

        private static void SeedProduct(Guid userId, DateTime insertedDate, ModelBuilder modelBuilder, Guid categoryId)
        {

            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = Guid.NewGuid(),
                  Name = GenerateRandomString(5),
                  Description = GenerateRandomString(20),
                  Price = 699.99m,
                  StockQuantity = 50,
                  Status = ProductStatus.Active,
                  CategoryId = categoryId,
                  InsertedBy = userId,
                  InsertedDate = insertedDate,
              }

          );
        }

        private static void SeedSubCategory(Guid userId, DateTime insertedDate, ModelBuilder modelBuilder, string Name, Guid parentId)
        {
            Random random = new Random();
            int range = random.Next(2, 20);

            var catId = Guid.Empty;
            for (int i = 0; i < range; i++)
            {
                catId = Guid.NewGuid();
                SeedCategory(userId, insertedDate, modelBuilder, string.Concat(Name, " ", GenerateRandomString(5)), catId, parentId);
                SeedProduct(userId, insertedDate, modelBuilder, catId);

            }
        }

        private static void SeedCategory(Guid userId, DateTime insertedDate, ModelBuilder modelBuilder, string Name, Guid rowId, Guid? ParentId)
        {
            modelBuilder.Entity<Category>().HasData(
              new Category
              {
                  Id = rowId,
                  Name = Name,
                  Description = Name + " Description",
                  ParentCategoryId = ParentId,
                  InsertedBy = userId,
                  InsertedDate = insertedDate,
              });

        }

        private static void SeedAdmin(Guid userId, DateTime insertedDate, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User
               {
                   Id = userId,
                   UserName = "admin",
                   Email = "Admin@urwave.com",
                   IsActive = true,
                   UserType = UserType.Admin,
                   Password = "f99c5521e65bcf281a101f9aa73351179c8e4daf"//admin
               });
        }

        private const string Charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string GenerateRandomString(int length)
        {
            return string.Create<object?>(length, null,
                static (chars, _) => Random.Shared.GetItems(Charset, chars));
        }
    }

}
