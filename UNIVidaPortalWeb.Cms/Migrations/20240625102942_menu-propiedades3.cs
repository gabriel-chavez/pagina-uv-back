using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class menupropiedades3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "MenuPrincipal",
                schema: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: true),
                    IdPadre = table.Column<int>(type: "integer", nullable: true),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    Visible = table.Column<bool>(type: "boolean", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuPrincipal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuPrincipal_MenuPrincipal_IdPadre",
                        column: x => x.IdPadre,
                        principalSchema: "Menu",
                        principalTable: "MenuPrincipal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuPrincipal_IdPadre",
                schema: "Menu",
                table: "MenuPrincipal",
                column: "IdPadre");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaginasDinamicas_MenuPrincipal_MenuId",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_MenuPrincipal_MenuId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropTable(
                name: "MenuPrincipal",
                schema: "Menu");

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPadre = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    Visible = table.Column<bool>(type: "boolean", nullable: false)
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
    }
}
