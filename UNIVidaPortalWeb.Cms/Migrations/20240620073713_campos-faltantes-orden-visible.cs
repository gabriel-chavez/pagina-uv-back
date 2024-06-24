using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class camposfaltantesordenvisible : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                schema: "Seguro",
                table: "Seguros",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                schema: "PaginaDinamica",
                table: "Secciones",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                schema: "Seguro",
                table: "Planes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Visible",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "Visible",
                schema: "PaginaDinamica",
                table: "Secciones");

            migrationBuilder.DropColumn(
                name: "Visible",
                schema: "Seguro",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "Visible",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");
        }
    }
}
