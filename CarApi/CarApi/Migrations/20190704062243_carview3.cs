using Microsoft.EntityFrameworkCore.Migrations;

namespace CarApi.Migrations
{
    public partial class carview3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Dealers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_BrandId",
                table: "Dealers",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dealers_Brands_BrandId",
                table: "Dealers",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dealers_Brands_BrandId",
                table: "Dealers");

            migrationBuilder.DropIndex(
                name: "IX_Dealers_BrandId",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Dealers");
        }
    }
}
