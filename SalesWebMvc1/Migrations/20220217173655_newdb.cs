using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretaryWebMvc.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PionerAux",
                table: "ActivitiesReport");

            migrationBuilder.AlterColumn<int>(
                name: "SumPublishers",
                table: "Congregation",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SumPublishers",
                table: "Congregation",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "PionerAux",
                table: "ActivitiesReport",
                nullable: false,
                defaultValue: false);
        }
    }
}
