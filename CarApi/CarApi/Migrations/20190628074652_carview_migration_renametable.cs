using Microsoft.EntityFrameworkCore.Migrations;

namespace CarApi.Migrations
{
    public partial class carview_migration_renametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Brands",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Brands");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "Brand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "Id");
        }
    }
}
