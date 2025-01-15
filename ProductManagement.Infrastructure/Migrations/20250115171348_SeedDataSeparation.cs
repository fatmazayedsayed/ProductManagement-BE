using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataSeparation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DeletedBy", "DeletedDate", "Description", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "ParentCategoryId", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("864267b8-8ab3-49a9-a6be-c65502bc9d92"), null, null, "Devices and gadgets", null, new DateTime(2025, 1, 15, 19, 13, 46, 619, DateTimeKind.Local).AddTicks(8441), false, "Electronics", null, (byte)1, null, null },
                    { new Guid("a5ad65c2-4dc2-47dc-9607-26c985e25daa"), null, null, "Men's and Women's apparel", null, new DateTime(2025, 1, 15, 19, 13, 46, 619, DateTimeKind.Local).AddTicks(8508), false, "Clothing", null, (byte)1, null, null },
                    { new Guid("ff7f6ac2-6635-45fa-aed7-14fbafd98109"), null, null, "Daily essentials and food items", null, new DateTime(2025, 1, 15, 19, 13, 46, 619, DateTimeKind.Local).AddTicks(8512), false, "Groceries", null, (byte)1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "Price", "Status", "StockQuantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3c9aee0c-8e03-4496-845c-1c03b3659aa5"), new Guid("864267b8-8ab3-49a9-a6be-c65502bc9d92"), null, null, "Latest model smartphone", null, null, new DateTime(2025, 1, 15, 19, 13, 46, 619, DateTimeKind.Local).AddTicks(8700), false, "Smartphone", 699.99m, (byte)1, 50, null, null },
                    { new Guid("45f2ea99-b517-44a1-84d7-cf55c1fe156a"), new Guid("a5ad65c2-4dc2-47dc-9607-26c985e25daa"), null, null, "Cotton T-shirt", null, null, new DateTime(2025, 1, 15, 19, 13, 46, 619, DateTimeKind.Local).AddTicks(8714), false, "T-Shirt", 19.99m, (byte)1, 200, null, null },
                    { new Guid("ca379a6a-ddaa-4dae-ae87-86005b6ce8a8"), new Guid("ff7f6ac2-6635-45fa-aed7-14fbafd98109"), null, null, "Organic pasta", null, null, new DateTime(2025, 1, 15, 19, 13, 46, 619, DateTimeKind.Local).AddTicks(8718), false, "Pasta", 4.99m, (byte)1, 100, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3c9aee0c-8e03-4496-845c-1c03b3659aa5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45f2ea99-b517-44a1-84d7-cf55c1fe156a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ca379a6a-ddaa-4dae-ae87-86005b6ce8a8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("864267b8-8ab3-49a9-a6be-c65502bc9d92"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a5ad65c2-4dc2-47dc-9607-26c985e25daa"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ff7f6ac2-6635-45fa-aed7-14fbafd98109"));
        }
    }
}
