using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class menumodel3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ruta",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "Ruta",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.EnsureSchema(
                name: "Menu");

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                schema: "Seguro",
                table: "Seguros",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    IdPadre = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_IdPadre",
                        column: x => x.IdPadre,
                        principalSchema: "Menu",
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_MenuId",
                schema: "Seguro",
                table: "Seguros",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_PaginasDinamicas_MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_IdPadre",
                schema: "Menu",
                table: "Menu",
                column: "IdPadre");

            migrationBuilder.AddForeignKey(
                name: "FK_PaginasDinamicas_Menu_MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                column: "MenuId",
                principalSchema: "Menu",
                principalTable: "Menu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_Menu_MenuId",
                schema: "Seguro",
                table: "Seguros",
                column: "MenuId",
                principalSchema: "Menu",
                principalTable: "Menu",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaginasDinamicas_Menu_MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_Menu_MenuId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Seguros_MenuId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropIndex(
                name: "IX_PaginasDinamicas_MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.DropColumn(
                name: "MenuId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                schema: "Seguro",
                table: "Seguros",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
