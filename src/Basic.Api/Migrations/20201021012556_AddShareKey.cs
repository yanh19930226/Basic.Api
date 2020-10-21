using Microsoft.EntityFrameworkCore.Migrations;

namespace Basic.Api.Migrations
{
    public partial class AddShareKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShareKey",
                table: "Shop",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShareKey",
                table: "Shop");
        }
    }
}
