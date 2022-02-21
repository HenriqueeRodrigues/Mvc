using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretaryWebMvc.Migrations
{
    public partial class FKAssistance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssistanceId",
                table: "ActivitiesReport",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesReport_AssistanceId",
                table: "ActivitiesReport",
                column: "AssistanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivitiesReport_Assistance_AssistanceId",
                table: "ActivitiesReport",
                column: "AssistanceId",
                principalTable: "Assistance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivitiesReport_Assistance_AssistanceId",
                table: "ActivitiesReport");

            migrationBuilder.DropIndex(
                name: "IX_ActivitiesReport_AssistanceId",
                table: "ActivitiesReport");

            migrationBuilder.DropColumn(
                name: "AssistanceId",
                table: "ActivitiesReport");
        }
    }
}
