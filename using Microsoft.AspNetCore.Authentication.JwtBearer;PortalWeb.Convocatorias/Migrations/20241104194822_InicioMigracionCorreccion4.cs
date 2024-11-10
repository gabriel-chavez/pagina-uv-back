using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Convocatorias.Migrations
{
    /// <inheritdoc />
    public partial class InicioMigracionCorreccion4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaTermino",
                schema: "Convocatorias",
                table: "Convocatoria",
                newName: "FechaFin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaFin",
                schema: "Convocatorias",
                table: "Convocatoria",
                newName: "FechaTermino");
        }
    }
}
