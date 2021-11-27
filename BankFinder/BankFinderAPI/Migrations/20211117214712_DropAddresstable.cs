using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace BankFinderAPI.Migrations
{
    public partial class DropAddresstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaneAdresowe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DaneAdresowe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KodPocztowy = table.Column<string>(type: "text", nullable: true),
                    KodPocztySkrytkiPocztowej = table.Column<string>(type: "text", nullable: true),
                    Kraj = table.Column<string>(type: "text", nullable: true),
                    Miejscowosc = table.Column<string>(type: "text", nullable: true),
                    NrSkrytkiPocztowej = table.Column<int>(type: "int", nullable: false),
                    NumerBudynku = table.Column<DateTime>(type: "datetime", nullable: false),
                    Poczta = table.Column<string>(type: "text", nullable: true),
                    Powiat = table.Column<string>(type: "text", nullable: true),
                    Ulica = table.Column<string>(type: "text", nullable: true),
                    Wojewodztwo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneAdresowe", x => x.Id);
                });
        }
    }
}
