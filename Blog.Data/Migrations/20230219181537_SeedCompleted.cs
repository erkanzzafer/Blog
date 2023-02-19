using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("12976718-de50-4fc8-803b-de0c49d8a3cf"), "Admin Test", new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8741), null, null, null, null, "Visual Studio", false },
                    { new Guid("94aafae7-cf2e-40c3-985d-c6755e6ddcdf"), "Admin Test", new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8737), null, null, null, null, "Asp.net Core", false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "ModifiedBy", "ModifiedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("984f6e20-56ae-40bd-9983-b72e587117d9"), "Admin Test", new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8868), null, null, "images/testimage", "jpg", null, null, false },
                    { new Guid("d357a9a6-ac4b-4722-9e0f-c59b91a14547"), "Admin Test", new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8872), null, null, "images/testimage", "png", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("10c0465a-9541-4845-8594-54813cb0e11e"), new Guid("12976718-de50-4fc8-803b-de0c49d8a3cf"), "VS is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin test", new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8481), null, null, new Guid("d357a9a6-ac4b-4722-9e0f-c59b91a14547"), null, null, "VS Deneme Makalesi 1", 15, false },
                    { new Guid("d18a1bcb-321d-4260-90bb-e39ea753b848"), new Guid("94aafae7-cf2e-40c3-985d-c6755e6ddcdf"), "Asp.net Core is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin test", new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8459), null, null, new Guid("984f6e20-56ae-40bd-9983-b72e587117d9"), null, null, "Asp.net Core Deneme Makalesi 1", 15, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("10c0465a-9541-4845-8594-54813cb0e11e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d18a1bcb-321d-4260-90bb-e39ea753b848"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12976718-de50-4fc8-803b-de0c49d8a3cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94aafae7-cf2e-40c3-985d-c6755e6ddcdf"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("984f6e20-56ae-40bd-9983-b72e587117d9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d357a9a6-ac4b-4722-9e0f-c59b91a14547"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
