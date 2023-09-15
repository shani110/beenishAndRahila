using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.DataAccess.Migrations
{
    public partial class addingcategoryProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryProductId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "categoryProductId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProducts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryProductId",
                table: "Products",
                column: "categoryProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_categoryProductId",
                table: "Categories",
                column: "categoryProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryProducts_categoryProductId",
                table: "Categories",
                column: "categoryProductId",
                principalTable: "CategoryProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CategoryProducts_categoryProductId",
                table: "Products",
                column: "categoryProductId",
                principalTable: "CategoryProducts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryProducts_categoryProductId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoryProducts_categoryProductId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CategoryProducts");

            migrationBuilder.DropIndex(
                name: "IX_Products_categoryProductId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Categories_categoryProductId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "categoryProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "categoryProductId",
                table: "Categories");
        }
    }
}
