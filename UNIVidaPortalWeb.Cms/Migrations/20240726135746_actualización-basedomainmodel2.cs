using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class actualizaciónbasedomainmodel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Seguro",
                table: "Seguros",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Recurso",
                table: "Recursos",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Seguro",
                table: "Planes",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "FechaModificacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Seguro",
                table: "Seguros",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Recurso",
                table: "Recursos",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Seguro",
                table: "Planes",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "FechaUltimaModificacion");
        }
    }
}
