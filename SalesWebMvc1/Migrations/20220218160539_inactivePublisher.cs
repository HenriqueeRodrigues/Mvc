using Microsoft.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretaryWebMvc.Migrations
{
    public partial class inactivePublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivitiesReport_Publisher_PublisherId",
                table: "ActivitiesReport");

            migrationBuilder.AlterColumn<double>(
                name: "Video",
                table: "ActivitiesReport",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Revisits",
                table: "ActivitiesReport",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "ActivitiesReport",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Publications",
                table: "ActivitiesReport",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "PlusHours",
                table: "ActivitiesReport",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Hours",
                table: "ActivitiesReport",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "BibleStudies",
                table: "ActivitiesReport",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<bool>(
                name: "PublisherRelated",
                table: "ActivitiesReport",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivitiesReport_Publisher_PublisherId",
                table: "ActivitiesReport",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivitiesReport_Publisher_PublisherId",
                table: "ActivitiesReport");

            migrationBuilder.DropColumn(
                name: "PublisherRelated",
                table: "ActivitiesReport");

            migrationBuilder.AlterColumn<double>(
                name: "Video",
                table: "ActivitiesReport",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Revisits",
                table: "ActivitiesReport",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "ActivitiesReport",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Publications",
                table: "ActivitiesReport",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PlusHours",
                table: "ActivitiesReport",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Hours",
                table: "ActivitiesReport",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "BibleStudies",
                table: "ActivitiesReport",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivitiesReport_Publisher_PublisherId",
                table: "ActivitiesReport",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
