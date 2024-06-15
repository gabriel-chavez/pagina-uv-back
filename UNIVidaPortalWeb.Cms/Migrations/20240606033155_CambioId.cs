using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class CambioId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeccionId",
                table: "Secciones",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RecursoId",
                table: "Recursos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PaginaDinamicaId",
                table: "PaginasDinamicas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DatoId",
                table: "Datos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CatTipoSeccionId",
                table: "CatTipoSeccion",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CatTipoRecursoId",
                table: "CatTipoRecurso",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BannerPaginaDinamicaId",
                table: "BannerPaginaDinamica",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Secciones",
                newName: "SeccionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Recursos",
                newName: "RecursoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PaginasDinamicas",
                newName: "PaginaDinamicaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Datos",
                newName: "DatoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatTipoSeccion",
                newName: "CatTipoSeccionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatTipoRecurso",
                newName: "CatTipoRecursoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BannerPaginaDinamica",
                newName: "BannerPaginaDinamicaId");
        }
    }
}
