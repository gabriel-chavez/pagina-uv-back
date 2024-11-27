using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class nuevaEntidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_CatTipoSeguro_CatTipoSeguroId",
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

            migrationBuilder.CreateTable(
                name: "BannerPaginaPrincipal",
                schema: "PaginaDinamica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Texto = table.Column<string>(type: "text", nullable: true),
                    Enlace = table.Column<string>(type: "text", nullable: false),
                    RecursoId = table.Column<int>(type: "integer", nullable: false),
                    NroSlider = table.Column<int>(type: "integer", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerPaginaPrincipal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BannerPaginaPrincipal_Recursos_RecursoId",
                        column: x => x.RecursoId,
                        principalSchema: "Recurso",
                        principalTable: "Recursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BannerPaginaPrincipal_RecursoId",
                schema: "PaginaDinamica",
                table: "BannerPaginaPrincipal",
                column: "RecursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_CatTipoSeguro_CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros",
                column: "CatTipoSeguroId",
                principalSchema: "Catalogo",
                principalTable: "CatTipoSeguro",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_CatTipoSeguro_CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropTable(
                name: "BannerPaginaPrincipal",
                schema: "PaginaDinamica");

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
    }
}
