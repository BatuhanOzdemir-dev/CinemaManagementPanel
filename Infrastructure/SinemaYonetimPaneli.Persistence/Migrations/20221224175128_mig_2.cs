using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinemaYonetimPaneli.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmGosterim");

            migrationBuilder.AddColumn<int>(
                name: "filmID",
                table: "Gosterims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Gosterims_filmID",
                table: "Gosterims",
                column: "filmID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterims_Films_filmID",
                table: "Gosterims",
                column: "filmID",
                principalTable: "Films",
                principalColumn: "filmID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gosterims_Films_filmID",
                table: "Gosterims");

            migrationBuilder.DropIndex(
                name: "IX_Gosterims_filmID",
                table: "Gosterims");

            migrationBuilder.DropColumn(
                name: "filmID",
                table: "Gosterims");

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
        }
    }
}
