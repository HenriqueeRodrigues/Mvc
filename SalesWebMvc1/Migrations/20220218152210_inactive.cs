using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretaryWebMvc.Migrations
{
    public partial class inactive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInactive",
                table: "Publisher",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInactive",
                table: "Publisher");
        }
    }
}
