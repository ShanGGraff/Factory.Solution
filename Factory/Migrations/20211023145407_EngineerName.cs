using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class EngineerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Engineers",
                newName: "EngineerName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EngineerName",
                table: "Engineers",
                newName: "Name");
        }
    }
}
