using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Desk.Infrastructure.Data.Migrations
{
    public partial class AddTableAssetStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalAsset = table.Column<decimal>(type: "TEXT", nullable: false),
                    Keyword = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    StatsType = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetStats", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetStats");
        }
    }
}
