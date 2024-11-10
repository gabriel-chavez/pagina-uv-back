using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Convocatorias.Migrations
{
    /// <inheritdoc />
    public partial class InicioMigracionCorreccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Parametricas");

            migrationBuilder.RenameTable(
                name: "ParTipoCapacitacion",
                newName: "ParTipoCapacitacion",
                newSchema: "Parametricas");

            migrationBuilder.RenameTable(
                name: "ParPrograma",
                newName: "ParPrograma",
                newSchema: "Parametricas");

            migrationBuilder.RenameTable(
                name: "ParParentesco",
                newName: "ParParentesco",
                newSchema: "Parametricas");

            migrationBuilder.RenameTable(
                name: "ParNivelFormacion",
                newName: "ParNivelFormacion",
                newSchema: "Parametricas");

            migrationBuilder.RenameTable(
                name: "ParNivelConocimiento",
                newName: "ParNivelConocimiento",
                newSchema: "Parametricas");

            migrationBuilder.RenameTable(
                name: "ParIdioma",
                newName: "ParIdioma",
                newSchema: "Parametricas");

            migrationBuilder.RenameTable(
                name: "ParEstadoPostulacion",
                newName: "ParEstadoPostulacion",
                newSchema: "Parametricas");

            migrationBuilder.RenameTable(
                name: "ParEstadoConvocatoria",
                newName: "ParEstadoConvocatoria",
                newSchema: "Parametricas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ParTipoCapacitacion",
                schema: "Parametricas",
                newName: "ParTipoCapacitacion");

            migrationBuilder.RenameTable(
                name: "ParPrograma",
                schema: "Parametricas",
                newName: "ParPrograma");

            migrationBuilder.RenameTable(
                name: "ParParentesco",
                schema: "Parametricas",
                newName: "ParParentesco");

            migrationBuilder.RenameTable(
                name: "ParNivelFormacion",
                schema: "Parametricas",
                newName: "ParNivelFormacion");

            migrationBuilder.RenameTable(
                name: "ParNivelConocimiento",
                schema: "Parametricas",
                newName: "ParNivelConocimiento");

            migrationBuilder.RenameTable(
                name: "ParIdioma",
                schema: "Parametricas",
                newName: "ParIdioma");

            migrationBuilder.RenameTable(
                name: "ParEstadoPostulacion",
                schema: "Parametricas",
                newName: "ParEstadoPostulacion");

            migrationBuilder.RenameTable(
                name: "ParEstadoConvocatoria",
                schema: "Parametricas",
                newName: "ParEstadoConvocatoria");
        }
    }
}
