using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class retirorutaadicionrelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ruta",
                schema: "Catalogo",
                table: "CatTipoSeguro");

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros",
                column: "CatTipoSeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_CatTipoSeguro_CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros",
                column: "CatTipoSeguroId",
                principalSchema: "Catalogo",
                principalTable: "CatTipoSeguro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_CatTipoSeguro_CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropIndex(
                name: "IX_Seguros_CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
