using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class ImagenSeccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenSeccion",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagenSeccionEjemplo",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenSeccion",
                schema: "Catalogo",
                table: "CatTipoSeccion");

            migrationBuilder.DropColumn(
                name: "ImagenSeccionEjemplo",
                schema: "Catalogo",
                table: "CatTipoSeccion");
        }
    }
}
