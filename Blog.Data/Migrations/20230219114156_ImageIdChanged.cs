using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImageIdChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_imageId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "imageId",
                table: "Articles",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_imageId",
                table: "Articles",
                newName: "IX_Articles_ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Articles",
                newName: "imageId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                newName: "IX_Articles_imageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_imageId",
                table: "Articles",
                column: "imageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
