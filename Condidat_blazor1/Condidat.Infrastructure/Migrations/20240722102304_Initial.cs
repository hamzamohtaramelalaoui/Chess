using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Condidat.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condidats",
                columns: table => new
                {
                    CondidatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexe = table.Column<int>(type: "int", nullable: false),
                    ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commune = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situation = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condidats", x => x.CondidatId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Villes",
                columns: table => new
                {
                    VilleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villes", x => x.VilleId);
                    table.ForeignKey(
                        name: "FK_Villes_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communes",
                columns: table => new
                {
                    CommuneId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VilleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communes", x => x.CommuneId);
                    table.ForeignKey(
                        name: "FK_Communes_Villes_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Villes",
                        principalColumn: "VilleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Name" },
                values: new object[,]
                {
                    { "1", "Rabat,Sale,Kenitra" },
                    { "2", "Casablanca,Settat" },
                    { "3", "Marrakech-Safi" },
                    { "4", "Fes,Meknes" },
                    { "5", "Tnger,Tetouin,Al houcaima" }
                });

            migrationBuilder.InsertData(
                table: "Villes",
                columns: new[] { "VilleId", "Name", "RegionId" },
                values: new object[,]
                {
                    { "1", "Rabat", "1" },
                    { "10", "Tanger", "5" },
                    { "11", "Tetouin", "5" },
                    { "12", "Al houcaima", "5" },
                    { "2", "Sale", "1" },
                    { "3", "kenitra", "1" },
                    { "4", "Casablanca", "2" },
                    { "5", "Settat", "2" },
                    { "6", "Marrakech", "3" },
                    { "7", "Safi", "3" },
                    { "8", "Fes", "4" },
                    { "9", "Meknes", "4" }
                });

            migrationBuilder.InsertData(
                table: "Communes",
                columns: new[] { "CommuneId", "Name", "VilleId" },
                values: new object[,]
                {
                    { "1", "Assilah", "10" },
                    { "10", "Skhirat-Temara", "1" },
                    { "11", "Khemissat", "1" },
                    { "12", "Sidi kasem", "3" },
                    { "13", "Sidi Sliman", "2" },
                    { "14", "Mohemmedia", "4" },
                    { "15", "Nouacer", "4" },
                    { "16", "Sidi Bennour", "5" },
                    { "17", "Chichaoua", "6" },
                    { "18", "Al Haouz", "6" },
                    { "19", "Rehamna", "7" },
                    { "2", "M'diq-Fnideq", "10" },
                    { "20", "Youssofia", "7" },
                    { "3", "Fahs-Anjra", "10" },
                    { "4", "Larache", "11" },
                    { "5", "Ouezzane", "11" },
                    { "7", "Elhajeb", "8" },
                    { "8", "Boulmane", "9" },
                    { "9", "Taounate", "9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Communes_VilleId",
                table: "Communes",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_Villes_RegionId",
                table: "Villes",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Communes");

            migrationBuilder.DropTable(
                name: "Condidats");

            migrationBuilder.DropTable(
                name: "Villes");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
