using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sport_shop_ver2.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhotoNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "sporting_products",
                newName: "photo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "photo",
                table: "sporting_products",
                newName: "Photo");
        }
    }
}
