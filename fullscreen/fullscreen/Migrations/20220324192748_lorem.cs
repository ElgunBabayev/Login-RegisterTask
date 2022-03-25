using Microsoft.EntityFrameworkCore.Migrations;

namespace fullscreen.Migrations
{
    public partial class lorem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectionHead",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Heading",
                table: "Abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SectionHead",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
