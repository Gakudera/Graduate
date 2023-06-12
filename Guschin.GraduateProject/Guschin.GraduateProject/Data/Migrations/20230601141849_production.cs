using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guschin.GraduateProject.Data.Migrations
{
    public partial class production : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Logo",
                schema: "production",
                table: "Products",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                schema: "production",
                table: "Products");
        }
    }
}
