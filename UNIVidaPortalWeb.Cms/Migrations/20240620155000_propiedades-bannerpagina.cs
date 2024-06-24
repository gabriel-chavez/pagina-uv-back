using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class propiedadesbannerpagina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BannerPagina_SeguroDetalles_SeguroId",
                schema: "Recurso",
                table: "BannerPagina");

            migrationBuilder.AddColumn<string>(
                name: "SubTitulo",
                schema: "Recurso",
                table: "BannerPagina",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                schema: "Recurso",
                table: "BannerPagina",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_BannerPagina_Seguros_SeguroId",
                schema: "Recurso",
                table: "BannerPagina",
                column: "SeguroId",
                principalSchema: "Seguro",
                principalTable: "Seguros",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BannerPagina_Seguros_SeguroId",
                schema: "Recurso",
                table: "BannerPagina");

            migrationBuilder.DropColumn(
                name: "SubTitulo",
                schema: "Recurso",
                table: "BannerPagina");

            migrationBuilder.DropColumn(
                name: "Titulo",
                schema: "Recurso",
                table: "BannerPagina");

            migrationBuilder.AddForeignKey(
                name: "FK_BannerPagina_SeguroDetalles_SeguroId",
                schema: "Recurso",
                table: "BannerPagina",
                column: "SeguroId",
                principalSchema: "Seguro",
                principalTable: "SeguroDetalles",
                principalColumn: "Id");
        }
    }
}
