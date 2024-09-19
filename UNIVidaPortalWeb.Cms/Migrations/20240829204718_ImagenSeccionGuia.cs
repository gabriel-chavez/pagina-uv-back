using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class ImagenSeccionGuia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagenSeccionEjemplo",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "ImagenSeccionGuia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagenSeccionGuia",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "ImagenSeccionEjemplo");
        }
    }
}
