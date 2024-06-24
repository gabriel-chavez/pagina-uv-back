using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class inicio1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeguroDetalles_CatTipoSeguroDetalles_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoSeguroDetalles",
                table: "CatTipoSeguroDetalles");

            migrationBuilder.RenameTable(
                name: "CatTipoSeguroDetalles",
                newName: "CatTipoSeguroDetalle",
                newSchema: "Catalogo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoSeguroDetalle",
                schema: "Catalogo",
                table: "CatTipoSeguroDetalle",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeguroDetalles_CatTipoSeguroDetalle_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles",
                column: "CatTipoSeguroDetalleId",
                principalSchema: "Catalogo",
                principalTable: "CatTipoSeguroDetalle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeguroDetalles_CatTipoSeguroDetalle_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoSeguroDetalle",
                schema: "Catalogo",
                table: "CatTipoSeguroDetalle");

            migrationBuilder.RenameTable(
                name: "CatTipoSeguroDetalle",
                schema: "Catalogo",
                newName: "CatTipoSeguroDetalles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoSeguroDetalles",
                table: "CatTipoSeguroDetalles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeguroDetalles_CatTipoSeguroDetalles_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles",
                column: "CatTipoSeguroDetalleId",
                principalTable: "CatTipoSeguroDetalles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
