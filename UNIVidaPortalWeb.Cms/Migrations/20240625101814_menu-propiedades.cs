using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class menupropiedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Visible",
                schema: "Seguro",
                table: "Seguros",
                newName: "Habilitado");

            migrationBuilder.RenameColumn(
                name: "Visible",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "Habilitado");

            migrationBuilder.RenameColumn(
                name: "Visible",
                schema: "Seguro",
                table: "Planes",
                newName: "Habilitado");

            migrationBuilder.RenameColumn(
                name: "Visible",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "Habilitado");

            migrationBuilder.AddColumn<bool>(
                name: "Habilitado",
                schema: "Menu",
                table: "Menu",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Orden",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                schema: "Menu",
                table: "Menu",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Habilitado",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Orden",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Visible",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "Habilitado",
                schema: "Seguro",
                table: "Seguros",
                newName: "Visible");

            migrationBuilder.RenameColumn(
                name: "Habilitado",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "Visible");

            migrationBuilder.RenameColumn(
                name: "Habilitado",
                schema: "Seguro",
                table: "Planes",
                newName: "Visible");

            migrationBuilder.RenameColumn(
                name: "Habilitado",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "Visible");
        }
    }
}
