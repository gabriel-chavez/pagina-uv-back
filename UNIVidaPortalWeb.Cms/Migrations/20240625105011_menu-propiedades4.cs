using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class menupropiedades4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaginasDinamicas_MenuPrincipal_MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_MenuPrincipal_MenuId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                schema: "Seguro",
                table: "Seguros",
                newName: "MenuPrincipalId");

            migrationBuilder.RenameIndex(
                name: "IX_Seguros_MenuId",
                schema: "Seguro",
                table: "Seguros",
                newName: "IX_Seguros_MenuPrincipalId");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "MenuPrincipalId");

            migrationBuilder.RenameIndex(
                name: "IX_PaginasDinamicas_MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "IX_PaginasDinamicas_MenuPrincipalId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaginasDinamicas_MenuPrincipal_MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_MenuPrincipal_MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.RenameColumn(
                name: "MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros",
                newName: "MenuId");

            migrationBuilder.RenameIndex(
                name: "IX_Seguros_MenuPrincipalId",
                schema: "Seguro",
                table: "Seguros",
                newName: "IX_Seguros_MenuId");

            migrationBuilder.RenameColumn(
                name: "MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "MenuId");

            migrationBuilder.RenameIndex(
                name: "IX_PaginasDinamicas_MenuPrincipalId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "IX_PaginasDinamicas_MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaginasDinamicas_MenuPrincipal_MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                column: "MenuId",
                principalSchema: "Menu",
                principalTable: "MenuPrincipal",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_MenuPrincipal_MenuId",
                schema: "Seguro",
                table: "Seguros",
                column: "MenuId",
                principalSchema: "Menu",
                principalTable: "MenuPrincipal",
                principalColumn: "Id");
        }
    }
}
