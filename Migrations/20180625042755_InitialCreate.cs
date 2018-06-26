using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YSCServer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Algorithms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Creator = table.Column<int>(nullable: false),
                    CrationTime = table.Column<DateTime>(nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Algorithms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leetcodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Creator = table.Column<int>(nullable: false),
                    CrationTime = table.Column<DateTime>(nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Difficultity = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Chapter = table.Column<string>(nullable: true),
                    AlgorithmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leetcodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YelpReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Creator = table.Column<int>(nullable: false),
                    CrationTime = table.Column<DateTime>(nullable: false),
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
                    table.PrimaryKey("PK_YelpReviews", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Algorithms");

            migrationBuilder.DropTable(
                name: "Leetcodes");

            migrationBuilder.DropTable(
                name: "YelpReviews");
        }
    }
}
