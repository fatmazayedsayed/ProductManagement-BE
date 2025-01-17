using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddatawithSubcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2db92873-586a-43b7-902e-5a2a7f0a1a19"));

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
                    { new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), null, null, "clothing Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing", null, (byte)1, null, null },
                    { new Guid("7199fd0a-cc03-46f0-9d21-2ad2e1ef8cbe"), null, null, "groceries Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "groceries", null, (byte)1, null, null },
                    { new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), null, null, "electronics Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics", null, (byte)1, null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DeletedBy", "DeletedDate", "Email", "InsertedBy", "InsertedDate", "IsActive", "IsDeleted", "Password", "UpdatedBy", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), null, null, "Admin@urwave.com", null, new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9624), true, false, "f99c5521e65bcf281a101f9aa73351179c8e4daf", null, null, "admin", 1 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DeletedBy", "DeletedDate", "Description", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "ParentCategoryId", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0b2b42be-7db5-44f6-a0a4-78ab09302772"), null, null, "electronics MA4Y0 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics MA4Y0", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("167cccb0-cc6a-4afd-9891-0b1d3331212e"), null, null, "electronics XJTQX Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics XJTQX", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("1cca563b-c04a-4678-861d-039b965cf2ce"), null, null, "clothing 0UJPH Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing 0UJPH", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("213d649d-acb8-4427-928a-8d465113730c"), null, null, "electronics 0921R Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics 0921R", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("23688319-5326-44b3-b4c9-fc5367778bad"), null, null, "electronics VPHEN Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics VPHEN", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("2c8db109-d414-460f-827d-bcaf9cd1aeee"), null, null, "clothing JQBP7 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing JQBP7", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("3865a01a-e2ab-44ac-8545-0e951468e25e"), null, null, "clothing IZ3C8 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing IZ3C8", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("47fe4807-c4fc-4f89-ac70-0a9729c453a4"), null, null, "clothing YWH6T Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing YWH6T", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("499f7d3f-8c6d-4814-9a2e-365b52c62ff1"), null, null, "electronics I38SC Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics I38SC", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("5b34c52a-ec54-458b-bf4a-98de6fb69ac8"), null, null, "clothing 3RVP9 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing 3RVP9", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("5c6c4f20-9ac2-421e-8416-45fd0fba87ff"), null, null, "groceries 76JGL Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "groceries 76JGL", new Guid("7199fd0a-cc03-46f0-9d21-2ad2e1ef8cbe"), (byte)1, null, null },
                    { new Guid("5f602127-55fa-4e12-a603-cdb4e6098d87"), null, null, "electronics 7GMLR Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics 7GMLR", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("66beb5ff-ca68-40b1-a516-c06901b2af03"), null, null, "clothing 7JKCH Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing 7JKCH", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("67c0bcd7-96c0-4732-b8de-4e168d0a02b1"), null, null, "electronics 87KT6 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics 87KT6", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("6ff655b0-b1aa-40bd-acba-df07dfd61600"), null, null, "groceries 4FS5A Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "groceries 4FS5A", new Guid("7199fd0a-cc03-46f0-9d21-2ad2e1ef8cbe"), (byte)1, null, null },
                    { new Guid("71e895d2-fb56-4278-91b3-ac2c30dec74d"), null, null, "clothing LXMG2 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing LXMG2", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("80a96349-60f4-44ca-86df-d9d10136ccfd"), null, null, "clothing IDPV6 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing IDPV6", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("972686da-f1d9-49f2-9656-b37fb6cc72fd"), null, null, "electronics JRAAU Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics JRAAU", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("a1f1b456-fcbb-4139-a15d-6dd8e8dfa267"), null, null, "electronics SEHG9 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics SEHG9", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("a41c1967-b118-4a98-afcc-8ee9929e12be"), null, null, "groceries IK2ZT Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "groceries IK2ZT", new Guid("7199fd0a-cc03-46f0-9d21-2ad2e1ef8cbe"), (byte)1, null, null },
                    { new Guid("b12a048f-0637-4677-98d7-4af22bcc12de"), null, null, "electronics 2SHY2 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics 2SHY2", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("b3f4b0a9-a73f-418a-bfb1-2c885bd34ed5"), null, null, "groceries DVK3Y Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "groceries DVK3Y", new Guid("7199fd0a-cc03-46f0-9d21-2ad2e1ef8cbe"), (byte)1, null, null },
                    { new Guid("c4d615d9-14b8-4277-89fe-01253a4afc05"), null, null, "clothing T2678 Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing T2678", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("cb803d35-5a7c-4503-b417-b6249873bb15"), null, null, "electronics S5IUH Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics S5IUH", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("d2576100-fff1-4ee1-9a14-b0dc07726e0c"), null, null, "electronics 4031A Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics 4031A", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("d4ebef1c-194c-49a1-b6ae-a30d1c112a5b"), null, null, "electronics ZLQOP Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics ZLQOP", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("dc25e4e3-c1a7-4521-b1c0-e732943ecc07"), null, null, "clothing TYWRN Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing TYWRN", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("df5f17d5-88a5-4bd5-941e-2d3c4bea9bc1"), null, null, "electronics OUFJK Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics OUFJK", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("e14ab559-a6a5-4f46-9955-9470cd906202"), null, null, "clothing OPW7N Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing OPW7N", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("e80c8906-f679-45f1-b094-2af95a65ab9a"), null, null, "clothing 02AUB Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing 02AUB", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("e83c05ad-a0ad-4bb1-b782-2d8ad3f299e5"), null, null, "electronics PZ39W Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics PZ39W", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("ec82c98d-dd8b-4894-8072-3fd1628ddb7d"), null, null, "electronics 61H9Z Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics 61H9Z", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("f79fca94-47c0-4215-aac2-540c57e6dd6f"), null, null, "electronics 8DSRI Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics 8DSRI", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null },
                    { new Guid("fb18d937-3182-4c1c-bf9c-4ac1871aaa08"), null, null, "clothing LCEID Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "clothing LCEID", new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), (byte)1, null, null },
                    { new Guid("ffe4e268-9a62-480c-8606-cdb4787f779a"), null, null, "electronics Z6NYS Description", new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "electronics Z6NYS", new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), (byte)1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "Price", "Status", "StockQuantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("443df9b3-6231-411e-9fe9-00dc031f2abb"), new Guid("7199fd0a-cc03-46f0-9d21-2ad2e1ef8cbe"), null, null, "X1XMP8RGBGUIF9JMF0DA", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "6TGAL", 699.99m, (byte)1, 50, null, null },
                    { new Guid("7012047f-a9fc-442f-8a88-5ad8212c570c"), new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), null, null, "6W2TRQGULS3PHCUNVJ62", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "EOVRX", 699.99m, (byte)1, 50, null, null },
                    { new Guid("a7b14531-69dd-4b87-9ad7-994788b517ea"), new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), null, null, "LN8SQVMA1ZALJOTJY9ZO", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "N20E1", 699.99m, (byte)1, 50, null, null },
                    { new Guid("d03de71a-a8e0-40c7-be1d-5e08d70a5d61"), new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"), null, null, "VSL90KJBY4KJN9U04YAP", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "3UE0Q", 699.99m, (byte)1, 50, null, null },
                    { new Guid("d24ad066-7425-4275-afe5-d5259be670e8"), new Guid("9b184e88-d905-4835-9e4f-20e9be869270"), null, null, "SUM1QRDFELZEFZB58ZYB", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "STIUA", 699.99m, (byte)1, 50, null, null },
                    { new Guid("f7cb324f-fbe3-4ea8-9190-3bb4940a3be7"), new Guid("7199fd0a-cc03-46f0-9d21-2ad2e1ef8cbe"), null, null, "ADMEOWMYIS1TLEXIKUVO", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "T6JYB", 699.99m, (byte)1, 50, null, null },
                    { new Guid("15c05556-7f63-42d2-8fe7-d17b88a18424"), new Guid("66beb5ff-ca68-40b1-a516-c06901b2af03"), null, null, "KHT5TP8KQI9R6BGB1DC0", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "5MC5E", 699.99m, (byte)1, 50, null, null },
                    { new Guid("1de09164-e4c1-43ab-b0d9-95251ccd8cde"), new Guid("6ff655b0-b1aa-40bd-acba-df07dfd61600"), null, null, "HMTINU5XOWA9773IHVSC", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "EW4GY", 699.99m, (byte)1, 50, null, null },
                    { new Guid("1e1106b3-6f66-41ed-95a1-31808ef03557"), new Guid("e14ab559-a6a5-4f46-9955-9470cd906202"), null, null, "2JZYU09FSQKMUOANSSJV", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "1N4SF", 699.99m, (byte)1, 50, null, null },
                    { new Guid("1e4397bf-131c-4bc4-80b0-36609f12114f"), new Guid("5b34c52a-ec54-458b-bf4a-98de6fb69ac8"), null, null, "G9J0M021SSKCTI0PD06P", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "DI1J0", 699.99m, (byte)1, 50, null, null },
                    { new Guid("25d5b126-ee5e-4d12-8e4d-625312b3429f"), new Guid("e83c05ad-a0ad-4bb1-b782-2d8ad3f299e5"), null, null, "8047N6BZSG3SY1MP3YBN", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "KZLC7", 699.99m, (byte)1, 50, null, null },
                    { new Guid("28efe428-0f7c-42e7-96c6-6ffd5b637356"), new Guid("f79fca94-47c0-4215-aac2-540c57e6dd6f"), null, null, "HUJJB9CZLYAQWXQ31JYX", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "U3I6C", 699.99m, (byte)1, 50, null, null },
                    { new Guid("34b006e2-a228-4808-96b8-312df853527b"), new Guid("972686da-f1d9-49f2-9656-b37fb6cc72fd"), null, null, "5BEO2WAT66Z0MSJRIEWL", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "R3V2I", 699.99m, (byte)1, 50, null, null },
                    { new Guid("36753cd4-6c00-4e8d-b87a-f94a3dbfe678"), new Guid("df5f17d5-88a5-4bd5-941e-2d3c4bea9bc1"), null, null, "NIB3KRHGIA2SC0RPBOXA", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "QGZW7", 699.99m, (byte)1, 50, null, null },
                    { new Guid("3d7fdd04-eb28-4174-86a1-6bb1be759938"), new Guid("499f7d3f-8c6d-4814-9a2e-365b52c62ff1"), null, null, "H6LMAVDQUUZ8LZTR9GIP", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "P4H1F", 699.99m, (byte)1, 50, null, null },
                    { new Guid("4c946dba-3653-408d-a57f-712ba28cc3a3"), new Guid("b3f4b0a9-a73f-418a-bfb1-2c885bd34ed5"), null, null, "KYN3LRP2HGRUQSX69NX2", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "NRS92", 699.99m, (byte)1, 50, null, null },
                    { new Guid("4e1cc65a-506f-42a2-a16a-6cbf841f40d0"), new Guid("5f602127-55fa-4e12-a603-cdb4e6098d87"), null, null, "PS7BBONPBT34O5H7UA2P", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "OCZAC", 699.99m, (byte)1, 50, null, null },
                    { new Guid("5b69dfb3-82ab-4953-b822-b0e0beb65f08"), new Guid("ec82c98d-dd8b-4894-8072-3fd1628ddb7d"), null, null, "YPOILWZZOY5HUS0TS6D7", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "4L6IQ", 699.99m, (byte)1, 50, null, null },
                    { new Guid("63290733-89d6-4ca4-b988-9bc858b0a96e"), new Guid("167cccb0-cc6a-4afd-9891-0b1d3331212e"), null, null, "PWTNCHKUKXREEZLVLRBX", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "0PAQ2", 699.99m, (byte)1, 50, null, null },
                    { new Guid("672f5360-0913-4ce3-bd52-f90fcaafe791"), new Guid("67c0bcd7-96c0-4732-b8de-4e168d0a02b1"), null, null, "CSLVCYE8NJQ1U5IUS8LA", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "8LVFQ", 699.99m, (byte)1, 50, null, null },
                    { new Guid("6c31740b-fbce-4158-9ba0-e4f86f65c58b"), new Guid("e80c8906-f679-45f1-b094-2af95a65ab9a"), null, null, "M378F69AWN690UA3KRMS", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "VQCOH", 699.99m, (byte)1, 50, null, null },
                    { new Guid("716ec7e9-48cb-49c6-ba3e-ff9dcb4945d9"), new Guid("2c8db109-d414-460f-827d-bcaf9cd1aeee"), null, null, "TO40L8YGRZ7PN0BYTLYH", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "AZ5W2", 699.99m, (byte)1, 50, null, null },
                    { new Guid("7f15dc12-e451-4eb1-9a13-d062c4f2ad9e"), new Guid("ffe4e268-9a62-480c-8606-cdb4787f779a"), null, null, "IDS8NO4Z3L7HJG2QAU2V", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "8GB4R", 699.99m, (byte)1, 50, null, null },
                    { new Guid("8677a79a-f980-4726-a352-727237e00c56"), new Guid("213d649d-acb8-4427-928a-8d465113730c"), null, null, "RLUHRRD49K6CMIKZBV10", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "NGPOG", 699.99m, (byte)1, 50, null, null },
                    { new Guid("870a7e22-e966-4cbd-b3f3-fa1d303a6e2a"), new Guid("a41c1967-b118-4a98-afcc-8ee9929e12be"), null, null, "4RLBNMK8CVXW4UWSUNR3", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "UFH9S", 699.99m, (byte)1, 50, null, null },
                    { new Guid("937a6548-9d16-4f94-b72f-6bbeb86b6ba1"), new Guid("47fe4807-c4fc-4f89-ac70-0a9729c453a4"), null, null, "VTWIJ8VMPLQBB938ZGFV", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "8WMNL", 699.99m, (byte)1, 50, null, null },
                    { new Guid("a0634f42-606a-4e38-869c-11176ddeaea4"), new Guid("cb803d35-5a7c-4503-b417-b6249873bb15"), null, null, "MTFBEUXUUWBGUEJ4DFUN", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "WZ8ZB", 699.99m, (byte)1, 50, null, null },
                    { new Guid("a984977a-8442-4afb-83e8-1fd95b993777"), new Guid("d4ebef1c-194c-49a1-b6ae-a30d1c112a5b"), null, null, "HI0CN1KLRFMEM5AVA5T4", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "JBZB0", 699.99m, (byte)1, 50, null, null },
                    { new Guid("ab58f02c-b053-48c2-b91b-5693f43299c1"), new Guid("b12a048f-0637-4677-98d7-4af22bcc12de"), null, null, "CWIXE8PZL5U0WKVGCYWP", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "0GOTW", 699.99m, (byte)1, 50, null, null },
                    { new Guid("b05882df-ea1f-455e-af30-2013cce5cce9"), new Guid("c4d615d9-14b8-4277-89fe-01253a4afc05"), null, null, "26T5CMNSEQ1QVLTXOCIP", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "8ET30", 699.99m, (byte)1, 50, null, null },
                    { new Guid("b2ff580f-1d81-4a5c-a67e-1e5c017b07b1"), new Guid("3865a01a-e2ab-44ac-8545-0e951468e25e"), null, null, "51ID8SAEWWER52D3QZ8H", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "T7G0X", 699.99m, (byte)1, 50, null, null },
                    { new Guid("b3d86704-07db-4fa7-839e-46e8c4d07ad0"), new Guid("23688319-5326-44b3-b4c9-fc5367778bad"), null, null, "14ZCR7PXMAHM6XDXFYB2", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "1BQ79", 699.99m, (byte)1, 50, null, null },
                    { new Guid("bb0b13db-5a10-45a1-90fd-056d74237165"), new Guid("a1f1b456-fcbb-4139-a15d-6dd8e8dfa267"), null, null, "SJNSHHHXOY77W0TQ0TQW", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "O75FK", 699.99m, (byte)1, 50, null, null },
                    { new Guid("c5032b06-bab2-4329-9ae7-8143fbac6a71"), new Guid("5c6c4f20-9ac2-421e-8416-45fd0fba87ff"), null, null, "OES0UO5U67ZV3TFPTNFO", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "WM1DV", 699.99m, (byte)1, 50, null, null },
                    { new Guid("c86fa0ed-1244-4a82-8f1a-d73f785ed243"), new Guid("80a96349-60f4-44ca-86df-d9d10136ccfd"), null, null, "SJSWL7QO0EN65DY1F9L6", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "NL0KP", 699.99m, (byte)1, 50, null, null },
                    { new Guid("cac2234a-5513-47fd-9afd-18ced8f9992c"), new Guid("0b2b42be-7db5-44f6-a0a4-78ab09302772"), null, null, "3O2QRN3VJXT0NOS2FPQR", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "ZJDR9", 699.99m, (byte)1, 50, null, null },
                    { new Guid("d7178542-3aa7-4b3e-94ee-44faa57222f0"), new Guid("71e895d2-fb56-4278-91b3-ac2c30dec74d"), null, null, "Q8H63PM00DN5JOKAGVXQ", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "0KDF7", 699.99m, (byte)1, 50, null, null },
                    { new Guid("e6e9be7b-a188-4831-adc6-c1be9b0431b8"), new Guid("fb18d937-3182-4c1c-bf9c-4ac1871aaa08"), null, null, "BV3WWA68ZNGG7SQFUUB7", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "NQFAW", 699.99m, (byte)1, 50, null, null },
                    { new Guid("e94c1d0e-2ed9-4c9b-bac5-bee11d723039"), new Guid("d2576100-fff1-4ee1-9a14-b0dc07726e0c"), null, null, "E4J7Y4SFNQZIYJU0S9P7", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "6PYUR", 699.99m, (byte)1, 50, null, null },
                    { new Guid("eb2c0e07-172d-443a-9ece-8e4e8f296392"), new Guid("1cca563b-c04a-4678-861d-039b965cf2ce"), null, null, "7TS02USOWH0QT99K5RST", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "SA2MI", 699.99m, (byte)1, 50, null, null },
                    { new Guid("eed9fe1f-29d4-4571-8d3d-620f2ec95275"), new Guid("dc25e4e3-c1a7-4521-b1c0-e732943ecc07"), null, null, "P79Z8G89C5EEQ2XDLDTN", null, new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"), new DateTime(2025, 1, 17, 10, 18, 42, 518, DateTimeKind.Local).AddTicks(9487), false, "AC88Q", 699.99m, (byte)1, 50, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("15c05556-7f63-42d2-8fe7-d17b88a18424"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1de09164-e4c1-43ab-b0d9-95251ccd8cde"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1e1106b3-6f66-41ed-95a1-31808ef03557"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1e4397bf-131c-4bc4-80b0-36609f12114f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("25d5b126-ee5e-4d12-8e4d-625312b3429f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("28efe428-0f7c-42e7-96c6-6ffd5b637356"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("34b006e2-a228-4808-96b8-312df853527b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36753cd4-6c00-4e8d-b87a-f94a3dbfe678"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3d7fdd04-eb28-4174-86a1-6bb1be759938"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("443df9b3-6231-411e-9fe9-00dc031f2abb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c946dba-3653-408d-a57f-712ba28cc3a3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4e1cc65a-506f-42a2-a16a-6cbf841f40d0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5b69dfb3-82ab-4953-b822-b0e0beb65f08"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("63290733-89d6-4ca4-b988-9bc858b0a96e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("672f5360-0913-4ce3-bd52-f90fcaafe791"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6c31740b-fbce-4158-9ba0-e4f86f65c58b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7012047f-a9fc-442f-8a88-5ad8212c570c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("716ec7e9-48cb-49c6-ba3e-ff9dcb4945d9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7f15dc12-e451-4eb1-9a13-d062c4f2ad9e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8677a79a-f980-4726-a352-727237e00c56"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("870a7e22-e966-4cbd-b3f3-fa1d303a6e2a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("937a6548-9d16-4f94-b72f-6bbeb86b6ba1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a0634f42-606a-4e38-869c-11176ddeaea4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a7b14531-69dd-4b87-9ad7-994788b517ea"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a984977a-8442-4afb-83e8-1fd95b993777"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ab58f02c-b053-48c2-b91b-5693f43299c1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b05882df-ea1f-455e-af30-2013cce5cce9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b2ff580f-1d81-4a5c-a67e-1e5c017b07b1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b3d86704-07db-4fa7-839e-46e8c4d07ad0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bb0b13db-5a10-45a1-90fd-056d74237165"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c5032b06-bab2-4329-9ae7-8143fbac6a71"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c86fa0ed-1244-4a82-8f1a-d73f785ed243"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cac2234a-5513-47fd-9afd-18ced8f9992c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d03de71a-a8e0-40c7-be1d-5e08d70a5d61"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d24ad066-7425-4275-afe5-d5259be670e8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d7178542-3aa7-4b3e-94ee-44faa57222f0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e6e9be7b-a188-4831-adc6-c1be9b0431b8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e94c1d0e-2ed9-4c9b-bac5-bee11d723039"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eb2c0e07-172d-443a-9ece-8e4e8f296392"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eed9fe1f-29d4-4571-8d3d-620f2ec95275"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f7cb324f-fbe3-4ea8-9190-3bb4940a3be7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8bfa8403-c87e-4332-b758-efd799d30cf9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0b2b42be-7db5-44f6-a0a4-78ab09302772"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("167cccb0-cc6a-4afd-9891-0b1d3331212e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1cca563b-c04a-4678-861d-039b965cf2ce"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("213d649d-acb8-4427-928a-8d465113730c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("23688319-5326-44b3-b4c9-fc5367778bad"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2c8db109-d414-460f-827d-bcaf9cd1aeee"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3865a01a-e2ab-44ac-8545-0e951468e25e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("47fe4807-c4fc-4f89-ac70-0a9729c453a4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("499f7d3f-8c6d-4814-9a2e-365b52c62ff1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5b34c52a-ec54-458b-bf4a-98de6fb69ac8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5c6c4f20-9ac2-421e-8416-45fd0fba87ff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5f602127-55fa-4e12-a603-cdb4e6098d87"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("66beb5ff-ca68-40b1-a516-c06901b2af03"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("67c0bcd7-96c0-4732-b8de-4e168d0a02b1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6ff655b0-b1aa-40bd-acba-df07dfd61600"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("71e895d2-fb56-4278-91b3-ac2c30dec74d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("80a96349-60f4-44ca-86df-d9d10136ccfd"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("972686da-f1d9-49f2-9656-b37fb6cc72fd"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a1f1b456-fcbb-4139-a15d-6dd8e8dfa267"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a41c1967-b118-4a98-afcc-8ee9929e12be"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b12a048f-0637-4677-98d7-4af22bcc12de"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b3f4b0a9-a73f-418a-bfb1-2c885bd34ed5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c4d615d9-14b8-4277-89fe-01253a4afc05"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cb803d35-5a7c-4503-b417-b6249873bb15"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d2576100-fff1-4ee1-9a14-b0dc07726e0c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d4ebef1c-194c-49a1-b6ae-a30d1c112a5b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dc25e4e3-c1a7-4521-b1c0-e732943ecc07"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("df5f17d5-88a5-4bd5-941e-2d3c4bea9bc1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e14ab559-a6a5-4f46-9955-9470cd906202"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e80c8906-f679-45f1-b094-2af95a65ab9a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e83c05ad-a0ad-4bb1-b782-2d8ad3f299e5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec82c98d-dd8b-4894-8072-3fd1628ddb7d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f79fca94-47c0-4215-aac2-540c57e6dd6f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("fb18d937-3182-4c1c-bf9c-4ac1871aaa08"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ffe4e268-9a62-480c-8606-cdb4787f779a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0c0eea9e-9a72-496a-b30f-69ab6c629473"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7199fd0a-cc03-46f0-9d21-2ad2e1ef8cbe"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9b184e88-d905-4835-9e4f-20e9be869270"));

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
    }
}
