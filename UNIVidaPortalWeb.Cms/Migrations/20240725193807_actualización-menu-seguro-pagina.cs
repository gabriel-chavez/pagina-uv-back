using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class actualizaciónmenuseguropagina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaginasDinamicas_MenuPrincipal_MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_MenuPrincipal_MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropIndex(
                name: "IX_Seguros_MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropIndex(
                name: "IX_PaginasDinamicas_MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.DropColumn(
                name: "MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.AddColumn<int>(
                name: "IdPaginaDinamica",
                schema: "Menu",
                table: "MenuPrincipal",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdSeguro",
                schema: "Menu",
                table: "MenuPrincipal",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuPrincipal_IdPaginaDinamica",
                schema: "Menu",
                table: "MenuPrincipal",
                column: "IdPaginaDinamica");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPrincipal_IdSeguro",
                schema: "Menu",
                table: "MenuPrincipal",
                column: "IdSeguro");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuPrincipal_PaginasDinamicas_IdPaginaDinamica",
                schema: "Menu",
                table: "MenuPrincipal",
                column: "IdPaginaDinamica",
                principalSchema: "PaginaDinamica",
                principalTable: "PaginasDinamicas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuPrincipal_Seguros_IdSeguro",
                schema: "Menu",
                table: "MenuPrincipal",
                column: "IdSeguro",
                principalSchema: "Seguro",
                principalTable: "Seguros",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuPrincipal_PaginasDinamicas_IdPaginaDinamica",
                schema: "Menu",
                table: "MenuPrincipal");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuPrincipal_Seguros_IdSeguro",
                schema: "Menu",
                table: "MenuPrincipal");

            migrationBuilder.DropIndex(
                name: "IX_MenuPrincipal_IdPaginaDinamica",
                schema: "Menu",
                table: "MenuPrincipal");

            migrationBuilder.DropIndex(
                name: "IX_MenuPrincipal_IdSeguro",
                schema: "Menu",
                table: "MenuPrincipal");

            migrationBuilder.DropColumn(
                name: "IdPaginaDinamica",
                schema: "Menu",
                table: "MenuPrincipal");

            migrationBuilder.DropColumn(
                name: "IdSeguro",
                schema: "Menu",
                table: "MenuPrincipal");

            migrationBuilder.AddColumn<int>(
                name: "MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros",
                column: "MenuPrincipalId");

            migrationBuilder.CreateIndex(
                name: "IX_PaginasDinamicas_MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                column: "MenuPrincipalId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaginasDinamicas_MenuPrincipal_MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                column: "MenuPrincipalId",
                principalSchema: "Menu",
                principalTable: "MenuPrincipal",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_MenuPrincipal_MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros",
                column: "MenuPrincipalId",
                principalSchema: "Menu",
                principalTable: "MenuPrincipal",
                principalColumn: "Id");
        }
    }
}
