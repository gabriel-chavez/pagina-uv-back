using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Noticias.Migrations
{
    /// <inheritdoc />
    public partial class RecursoIdOpcional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Noticia_Recurso_RecursoId_ImagenPrincipal",
                schema: "Noticias",
                table: "Noticia");

            migrationBuilder.AlterColumn<int>(
                name: "RecursoId_ImagenPrincipal",
                schema: "Noticias",
                table: "Noticia",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Noticia_Recurso_RecursoId_ImagenPrincipal",
                schema: "Noticias",
                table: "Noticia",
                column: "RecursoId_ImagenPrincipal",
                principalSchema: "Noticias",
                principalTable: "Recurso",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Noticia_Recurso_RecursoId_ImagenPrincipal",
                schema: "Noticias",
                table: "Noticia");

            migrationBuilder.AlterColumn<int>(
                name: "RecursoId_ImagenPrincipal",
                schema: "Noticias",
                table: "Noticia",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Noticia_Recurso_RecursoId_ImagenPrincipal",
                schema: "Noticias",
                table: "Noticia",
                column: "RecursoId_ImagenPrincipal",
                principalSchema: "Noticias",
                principalTable: "Recurso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
