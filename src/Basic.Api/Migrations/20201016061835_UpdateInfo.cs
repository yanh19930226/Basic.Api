using Microsoft.EntityFrameworkCore.Migrations;

namespace Basic.Api.Migrations
{
    public partial class UpdateInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApiKeyValue",
                table: "Shop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApiUrl",
                table: "Shop",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiKeyValue",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ApiUrl",
                table: "Shop");
        }
    }
}
