using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DeletedBy", "DeletedDate", "Description", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "ParentCategoryId", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("001076b4-9293-459d-b2bc-44f4bc3b8096"), null, null, "Daily essentials and food items", null, new DateTime(2025, 1, 16, 0, 34, 18, 272, DateTimeKind.Local).AddTicks(4372), false, "Groceries", null, (byte)1, null, null },
                    { new Guid("6afb56f8-7d1e-4d1e-b21e-37c3b49d8623"), null, null, "Devices and gadgets", null, new DateTime(2025, 1, 16, 0, 34, 18, 272, DateTimeKind.Local).AddTicks(4363), false, "Electronics", null, (byte)1, null, null },
                    { new Guid("cd9fb4d9-9db3-4249-809d-ffa0833d1d30"), null, null, "Men's and Women's apparel", null, new DateTime(2025, 1, 16, 0, 34, 18, 272, DateTimeKind.Local).AddTicks(4369), false, "Clothing", null, (byte)1, null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DeletedBy", "DeletedDate", "Email", "InsertedBy", "InsertedDate", "IsActive", "IsDeleted", "Password", "UpdatedBy", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { new Guid("2db92873-586a-43b7-902e-5a2a7f0a1a19"), null, null, "Admin@urwave.com", null, new DateTime(2025, 1, 16, 0, 34, 18, 272, DateTimeKind.Local).AddTicks(4233), true, false, "f99c5521e65bcf281a101f9aa73351179c8e4daf", null, null, "admin", 1 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "Price", "Status", "StockQuantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("475b69ce-9724-4e42-a9dd-eea1685228bf"), new Guid("6afb56f8-7d1e-4d1e-b21e-37c3b49d8623"), null, null, "Latest model smartphone", null, null, new DateTime(2025, 1, 16, 0, 34, 18, 272, DateTimeKind.Local).AddTicks(4398), false, "Smartphone", 699.99m, (byte)1, 50, null, null },
                    { new Guid("d8ebf129-2c3f-41c4-a804-0d86b813b6d4"), new Guid("cd9fb4d9-9db3-4249-809d-ffa0833d1d30"), null, null, "Cotton T-shirt", null, null, new DateTime(2025, 1, 16, 0, 34, 18, 272, DateTimeKind.Local).AddTicks(4411), false, "T-Shirt", 19.99m, (byte)1, 200, null, null },
                    { new Guid("fdd83d05-1ad5-4c79-bd20-9071da669721"), new Guid("001076b4-9293-459d-b2bc-44f4bc3b8096"), null, null, "Organic pasta", null, null, new DateTime(2025, 1, 16, 0, 34, 18, 272, DateTimeKind.Local).AddTicks(4415), false, "Pasta", 4.99m, (byte)1, 100, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("475b69ce-9724-4e42-a9dd-eea1685228bf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d8ebf129-2c3f-41c4-a804-0d86b813b6d4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fdd83d05-1ad5-4c79-bd20-9071da669721"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("001076b4-9293-459d-b2bc-44f4bc3b8096"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6afb56f8-7d1e-4d1e-b21e-37c3b49d8623"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cd9fb4d9-9db3-4249-809d-ffa0833d1d30"));

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
    }
}
