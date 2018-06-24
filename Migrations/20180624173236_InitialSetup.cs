using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YSCServer.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YelpReviews",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Creator = table.Column<int>(nullable: false),
                    CrationTIme = table.Column<DateTime>(nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ReviewId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    BusinessId = table.Column<string>(nullable: true),
                    text = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    stars = table.Column<int>(nullable: false),
                    cool = table.Column<int>(nullable: false),
                    funny = table.Column<int>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    useful = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YelpReviews", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YelpReviews");
        }
    }
}
