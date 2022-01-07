using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretaryWebMvc.Migrations
{
    public partial class PRIMEIROADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Congregation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Congregation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 60, nullable: false),
                    SimpleAddress = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BaptismDate = table.Column<DateTime>(nullable: false),
                    IsAnointed = table.Column<bool>(nullable: false),
                    IsElder = table.Column<bool>(nullable: false),
                    IsMinisterialServant = table.Column<bool>(nullable: false),
                    Ispioneer = table.Column<bool>(nullable: false),
                    CongregationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publisher_Congregation_CongregationId",
                        column: x => x.CongregationId,
                        principalTable: "Congregation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(maxLength: 15, nullable: false),
                    Senha = table.Column<string>(maxLength: 15, nullable: false),
                    IsAdm = table.Column<bool>(nullable: true),
                    CongregationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Congregation_CongregationId",
                        column: x => x.CongregationId,
                        principalTable: "Congregation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesReport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Publications = table.Column<double>(nullable: false),
                    Video = table.Column<double>(nullable: false),
                    Hours = table.Column<double>(nullable: false),
                    Revisits = table.Column<double>(nullable: false),
                    BibleStudies = table.Column<double>(nullable: false),
                    PlusHours = table.Column<double>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    PublisherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivitiesReport_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesReport_PublisherId",
                table: "ActivitiesReport",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Publisher_CongregationId",
                table: "Publisher",
                column: "CongregationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CongregationId",
                table: "User",
                column: "CongregationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesReport");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Congregation");
        }
    }
}
