using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace BankFinderAPI.Migrations
{
    public partial class AddMainTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "SortCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OpeningHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Monday = table.Column<string>(type: "text", nullable: true),
                    Tuesday = table.Column<string>(type: "text", nullable: true),
                    Wednesday = table.Column<string>(type: "text", nullable: true),
                    Thursday = table.Column<string>(type: "text", nullable: true),
                    Friday = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RegistrationNumber = table.Column<string>(type: "text", nullable: true),
                    UnitType = table.Column<string>(type: "text", nullable: true),
                    UnitName = table.Column<string>(type: "text", nullable: true),
                    LetterSymbol = table.Column<string>(type: "text", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    DateOfCompanyStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    OpeningHoursId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_OpeningHours_OpeningHoursId",
                        column: x => x.OpeningHoursId,
                        principalTable: "OpeningHours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaxNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(type: "text", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaxNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaxNumber_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(type: "text", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SortCode_UnitId",
                table: "SortCode",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_FaxNumber_UnitId",
                table: "FaxNumber",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_UnitId",
                table: "PhoneNumber",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_AddressId",
                table: "Unit",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_OpeningHoursId",
                table: "Unit",
                column: "OpeningHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_SortCode_Unit_UnitId",
                table: "SortCode",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SortCode_Unit_UnitId",
                table: "SortCode");

            migrationBuilder.DropTable(
                name: "FaxNumber");

            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "OpeningHours");

            migrationBuilder.DropIndex(
                name: "IX_SortCode_UnitId",
                table: "SortCode");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "SortCode");
        }
    }
}
