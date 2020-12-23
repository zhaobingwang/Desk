using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Desk.Infrastructure.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeCode = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    TypeName = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    TotalAsset = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Code = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Method = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "SysDict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    TypeCode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TypeName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsBuiltin = table.Column<int>(type: "INTEGER", maxLength: 1, nullable: false),
                    Status = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    InternalVersion = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreateUser = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateUser = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysDict", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysDictType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    IsBuiltin = table.Column<int>(type: "INTEGER", maxLength: 1, nullable: false),
                    Status = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    InternalVersion = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreateUser = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateUser = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysDictType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetType_Name",
                table: "AssetType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SysDict_Code_InternalVersion_TypeCode",
                table: "SysDict",
                columns: new[] { "Code", "InternalVersion", "TypeCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SysDictType_Code_InternalVersion",
                table: "SysDictType",
                columns: new[] { "Code", "InternalVersion" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetRecord");

            migrationBuilder.DropTable(
                name: "AssetType");

            migrationBuilder.DropTable(
                name: "SysDict");

            migrationBuilder.DropTable(
                name: "SysDictType");
        }
    }
}
