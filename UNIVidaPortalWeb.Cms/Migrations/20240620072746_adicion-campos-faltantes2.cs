using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class adicioncamposfaltantes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icono",
                schema: "Seguro",
                table: "Seguros",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Orden",
                schema: "Seguro",
                table: "Seguros",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecursoId",
                schema: "Seguro",
                table: "Seguros",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_RecursoId",
                schema: "Seguro",
                table: "Seguros",
                column: "RecursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_Recursos_RecursoId",
                schema: "Seguro",
                table: "Seguros",
                column: "RecursoId",
                principalSchema: "Recurso",
                principalTable: "Recursos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_Recursos_RecursoId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropIndex(
                name: "IX_Seguros_RecursoId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "Icono",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "Orden",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "RecursoId",
                schema: "Seguro",
                table: "Seguros");
        }
    }
}
