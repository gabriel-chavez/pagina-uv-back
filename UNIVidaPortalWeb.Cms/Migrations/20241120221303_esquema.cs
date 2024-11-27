using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class esquema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BannerPaginaPrincipal",
                schema: "PaginaDinamica",
                newName: "BannerPaginaPrincipal",
                newSchema: "Recurso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BannerPaginaPrincipal",
                schema: "Recurso",
                newName: "BannerPaginaPrincipal",
                newSchema: "PaginaDinamica");
        }
    }
}
