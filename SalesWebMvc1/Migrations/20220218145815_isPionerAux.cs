using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretaryWebMvc.Migrations
{
    public partial class isPionerAux : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPionerAux",
                table: "ActivitiesReport",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPionerAux",
                table: "ActivitiesReport");
        }
    }
}
