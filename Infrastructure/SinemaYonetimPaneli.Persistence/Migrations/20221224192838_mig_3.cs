using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinemaYonetimPaneli.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gosterims_Films_filmID",
                table: "Gosterims");

            migrationBuilder.AlterColumn<int>(
                name: "filmID",
                table: "Gosterims",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterims_Films_filmID",
                table: "Gosterims",
                column: "filmID",
                principalTable: "Films",
                principalColumn: "filmID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gosterims_Films_filmID",
                table: "Gosterims");

            migrationBuilder.AlterColumn<int>(
                name: "filmID",
                table: "Gosterims",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterims_Films_filmID",
                table: "Gosterims",
                column: "filmID",
                principalTable: "Films",
                principalColumn: "filmID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
