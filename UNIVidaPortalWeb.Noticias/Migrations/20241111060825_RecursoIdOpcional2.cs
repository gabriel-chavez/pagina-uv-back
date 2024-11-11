using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Noticias.Migrations
{
    /// <inheritdoc />
    public partial class RecursoIdOpcional2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParEstado",
                schema: "Noticias",
                table: "Noticia",
                newName: "ParEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_ParEstadoId",
                schema: "Noticias",
                table: "Noticia",
                column: "ParEstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Noticia_ParEstado_ParEstadoId",
                schema: "Noticias",
                table: "Noticia",
                column: "ParEstadoId",
                principalSchema: "Parametricas",
                principalTable: "ParEstado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Noticia_ParEstado_ParEstadoId",
                schema: "Noticias",
                table: "Noticia");

            migrationBuilder.DropIndex(
                name: "IX_Noticia_ParEstadoId",
                schema: "Noticias",
                table: "Noticia");

            migrationBuilder.RenameColumn(
                name: "ParEstadoId",
                schema: "Noticias",
                table: "Noticia",
                newName: "ParEstado");
        }
    }
}
