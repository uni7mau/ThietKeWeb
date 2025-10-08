using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreLAB6_EF_BTTL.Migrations
{
    /// <inheritdoc />
    public partial class BannerUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BannerId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Banner",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BannerId",
                table: "Product",
                column: "BannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Banner_BannerId",
                table: "Product",
                column: "BannerId",
                principalTable: "Banner",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Banner_BannerId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_BannerId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BannerId",
                table: "Product");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Banner",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }
    }
}
