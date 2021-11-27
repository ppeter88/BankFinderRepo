using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace BankFinderAPI.Migrations
{
    public partial class AddInsitutionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstitutionId",
                table: "Unit",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Institution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    InstitutionType = table.Column<string>(type: "text", nullable: true),
                    InstitutionSubType = table.Column<string>(type: "text", nullable: true),
                    InstitutionNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Lettersymbol = table.Column<string>(type: "text", nullable: true),
                    DateOfCompanyStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIN = table.Column<string>(type: "text", nullable: true),
                    LEIIdent = table.Column<string>(type: "text", nullable: true),
                    WWW = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institution", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Unit_InstitutionId",
                table: "Unit",
                column: "InstitutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Institution_InstitutionId",
                table: "Unit",
                column: "InstitutionId",
                principalTable: "Institution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Institution_InstitutionId",
                table: "Unit");

            migrationBuilder.DropTable(
                name: "Institution");

            migrationBuilder.DropIndex(
                name: "IX_Unit_InstitutionId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "InstitutionId",
                table: "Unit");
        }
    }
}
