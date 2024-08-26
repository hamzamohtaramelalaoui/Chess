using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chess_Game.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mychess_games",
                columns: table => new
                {
                    id_Game = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    victory_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    opening_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurnsG = table.Column<int>(type: "int", nullable: false),
                    the_white_rating = table.Column<int>(type: "int", nullable: false),
                    the_black_rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mychess_games", x => x.id_Game);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mychess_games");
        }
    }
}
