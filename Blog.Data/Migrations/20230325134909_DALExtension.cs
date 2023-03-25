using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("10c0465a-9541-4845-8594-54813cb0e11e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d18a1bcb-321d-4260-90bb-e39ea753b848"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("16e4bc86-a5d8-4e60-9ce0-bfead86b284f"), new Guid("12976718-de50-4fc8-803b-de0c49d8a3cf"), "VS is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin test", new DateTime(2023, 3, 25, 16, 49, 9, 632, DateTimeKind.Local).AddTicks(1810), null, null, new Guid("d357a9a6-ac4b-4722-9e0f-c59b91a14547"), null, null, "VS Deneme Makalesi 1", 15, false },
                    { new Guid("8ce3a5a2-9076-4031-a0c4-51a1da3c9f12"), new Guid("94aafae7-cf2e-40c3-985d-c6755e6ddcdf"), "Asp.net Core is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin test", new DateTime(2023, 3, 25, 16, 49, 9, 632, DateTimeKind.Local).AddTicks(1803), null, null, new Guid("984f6e20-56ae-40bd-9983-b72e587117d9"), null, null, "Asp.net Core Deneme Makalesi 1", 15, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12976718-de50-4fc8-803b-de0c49d8a3cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 25, 16, 49, 9, 632, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94aafae7-cf2e-40c3-985d-c6755e6ddcdf"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 25, 16, 49, 9, 632, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("984f6e20-56ae-40bd-9983-b72e587117d9"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 25, 16, 49, 9, 632, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d357a9a6-ac4b-4722-9e0f-c59b91a14547"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 25, 16, 49, 9, 632, DateTimeKind.Local).AddTicks(2268));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("16e4bc86-a5d8-4e60-9ce0-bfead86b284f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8ce3a5a2-9076-4031-a0c4-51a1da3c9f12"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("10c0465a-9541-4845-8594-54813cb0e11e"), new Guid("12976718-de50-4fc8-803b-de0c49d8a3cf"), "VS is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin test", new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8481), null, null, new Guid("d357a9a6-ac4b-4722-9e0f-c59b91a14547"), null, null, "VS Deneme Makalesi 1", 15, false },
                    { new Guid("d18a1bcb-321d-4260-90bb-e39ea753b848"), new Guid("94aafae7-cf2e-40c3-985d-c6755e6ddcdf"), "Asp.net Core is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin test", new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8459), null, null, new Guid("984f6e20-56ae-40bd-9983-b72e587117d9"), null, null, "Asp.net Core Deneme Makalesi 1", 15, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12976718-de50-4fc8-803b-de0c49d8a3cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94aafae7-cf2e-40c3-985d-c6755e6ddcdf"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("984f6e20-56ae-40bd-9983-b72e587117d9"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d357a9a6-ac4b-4722-9e0f-c59b91a14547"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 19, 21, 15, 37, 53, DateTimeKind.Local).AddTicks(8872));
        }
    }
}
