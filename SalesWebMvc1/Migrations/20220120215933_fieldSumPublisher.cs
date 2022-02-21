using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretaryWebMvc.Migrations
{
    public partial class fieldSumPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SumPublishers",
                table: "Congregation",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PionerAux",
                table: "ActivitiesReport",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SumPublishers",
                table: "Congregation");

            migrationBuilder.AlterColumn<bool>(
                name: "PionerAux",
                table: "ActivitiesReport",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
