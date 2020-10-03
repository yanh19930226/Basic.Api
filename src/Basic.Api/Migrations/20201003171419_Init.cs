using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Basic.Api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDel = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SkuPrefix = table.Column<string>(nullable: true),
                    AdditionalFee = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDel = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<long>(nullable: false),
                    ApiKey = table.Column<string>(nullable: true),
                    IsOpen = table.Column<int>(nullable: false),
                    Types = table.Column<int>(nullable: false),
                    OrderPrefix = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    Domain = table.Column<string>(nullable: true),
                    AdminUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shop_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shop_CompanyId",
                table: "Shop",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
