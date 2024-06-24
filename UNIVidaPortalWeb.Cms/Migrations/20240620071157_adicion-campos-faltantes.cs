using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class adicioncamposfaltantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetalleAdicional",
                schema: "Seguro",
                table: "Seguros",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Orden",
                schema: "Seguro",
                table: "SeguroDetalles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Orden",
                schema: "Seguro",
                table: "Planes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetalleAdicional",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "Orden",
                schema: "Seguro",
                table: "SeguroDetalles");

            migrationBuilder.DropColumn(
                name: "Orden",
                schema: "Seguro",
                table: "Planes");
        }
    }
}
