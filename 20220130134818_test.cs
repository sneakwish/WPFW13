using Microsoft.EntityFrameworkCore.Migrations;

namespace WPFW13.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "manvrouw",
                table: "Student",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "manvrouw",
                table: "Student");
        }
    }
}
