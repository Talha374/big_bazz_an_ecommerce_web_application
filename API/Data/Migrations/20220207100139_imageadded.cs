using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class imageadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "SubSubMenu",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "SubMenu",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Menu",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "SubSubMenu");

            migrationBuilder.DropColumn(
                name: "image",
                table: "SubMenu");

            migrationBuilder.DropColumn(
                name: "image",
                table: "Menu");

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    AppUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => new { x.AppUserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Favorites_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ProductId",
                table: "Favorites",
                column: "ProductId");
        }
    }
}
