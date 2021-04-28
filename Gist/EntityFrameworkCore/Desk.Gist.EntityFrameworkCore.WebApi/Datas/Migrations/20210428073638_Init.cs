using Microsoft.EntityFrameworkCore.Migrations;

namespace Desk.Gist.EntityFrameworkCore.WebApi.Datas.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dev");

            migrationBuilder.CreateTable(
                name: "blogs",
                schema: "dev",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false, comment: "Blog url")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.Id);
                },
                comment: "Blogs managed on the website");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogs",
                schema: "dev");
        }
    }
}
