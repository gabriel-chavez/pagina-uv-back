using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class cambioEsquema1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BannerPaginaPrincipal",
                schema: "Recurso",
                newName: "BannerPaginaPrincipal",
                newSchema: "PaginaDinamica");

            migrationBuilder.RenameTable(
                name: "BannerPagina",
                schema: "Recurso",
                newName: "BannerPagina",
                newSchema: "PaginaDinamica");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BannerPaginaPrincipal",
                schema: "PaginaDinamica",
                newName: "BannerPaginaPrincipal",
                newSchema: "Recurso");

            migrationBuilder.RenameTable(
                name: "BannerPagina",
                schema: "PaginaDinamica",
                newName: "BannerPagina",
                newSchema: "Recurso");
        }
    }
}
