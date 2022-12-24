using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinemaYonetimPaneli.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    filmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filmYapimYil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.filmID);
                });

            migrationBuilder.CreateTable(
                name: "Salons",
                columns: table => new
                {
                    salonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salonAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salons", x => x.salonID);
                });

            migrationBuilder.CreateTable(
                name: "Gosterims",
                columns: table => new
                {
                    gosterimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gosterimYil = table.Column<int>(type: "int", nullable: false),
                    salonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gosterims", x => x.gosterimID);
                    table.ForeignKey(
                        name: "FK_Gosterims_Salons_salonID",
                        column: x => x.salonID,
                        principalTable: "Salons",
                        principalColumn: "salonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmGosterim",
                columns: table => new
                {
                    filmsfilmID = table.Column<int>(type: "int", nullable: false),
                    gosterimsgosterimID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGosterim", x => new { x.filmsfilmID, x.gosterimsgosterimID });
                    table.ForeignKey(
                        name: "FK_FilmGosterim_Films_filmsfilmID",
                        column: x => x.filmsfilmID,
                        principalTable: "Films",
                        principalColumn: "filmID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmGosterim_Gosterims_gosterimsgosterimID",
                        column: x => x.gosterimsgosterimID,
                        principalTable: "Gosterims",
                        principalColumn: "gosterimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmGosterim_gosterimsgosterimID",
                table: "FilmGosterim",
                column: "gosterimsgosterimID");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterims_salonID",
                table: "Gosterims",
                column: "salonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmGosterim");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Gosterims");

            migrationBuilder.DropTable(
                name: "Salons");
        }
    }
}
