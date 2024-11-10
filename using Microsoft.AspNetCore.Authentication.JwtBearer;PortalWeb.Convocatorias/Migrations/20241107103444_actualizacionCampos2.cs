using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Convocatorias.Migrations
{
    /// <inheritdoc />
    public partial class actualizacionCampos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ExperienciaLaboral",
                newName: "ExperienciaLaboral",
                newSchema: "Postulantes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ExperienciaLaboral",
                schema: "Postulantes",
                newName: "ExperienciaLaboral");
        }
    }
}
